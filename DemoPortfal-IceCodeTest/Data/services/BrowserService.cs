using Microsoft.JSInterop;
namespace  DemoPortfal_IceCodeTest.Data {
    public class BrowserService {
        private IJSRuntime? JS = null;
        public event EventHandler<int>? Resize;
        private int browserWidth;
        private int browserHeight;
        public async void Init(IJSRuntime js) {
            // enforce single invocation            
            if (JS == null) {
                this.JS = js;
                await JS.InvokeAsync<string>("resizeListener", DotNetObjectReference.Create(this));
            }
        }
        
        [JSInvokable]
        public void SetBrowserDimensions(int jsBrowserWidth, int jsBrowserHeight) {
            browserWidth = jsBrowserWidth;
            browserHeight = jsBrowserHeight;
            this.Resize?.Invoke(this,jsBrowserWidth);
        }

        public async Task<BrowserDimension> GetDimensions()
        {
            if (JS != null) {
                return await JS.InvokeAsync<BrowserDimension>("getDimensions");
            }
            return new BrowserDimension();
        }
    }
    public class BrowserDimension
    {
        public int Width { get; set; } = 1600;
        public int Height { get; set; } = 900;
    }
}