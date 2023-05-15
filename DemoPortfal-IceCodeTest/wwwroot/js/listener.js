function resizeListener(dotnethelper) {
    window.getDimensions = function() {
        return {
                width: window.innerWidth,
                height: window.innerHeight
            };
    };
    $(window).resize(() => {
        let browserHeight = $(window).innerHeight();
        let browserWidth = $(window).innerWidth();
        dotnethelper.invokeMethodAsync('SetBrowserDimensions', browserWidth, browserHeight).then(() => {
            // success, do nothing
        }).catch(error => {
            console.log("Error during browser resize: " + error);
        });
    });
}

   
