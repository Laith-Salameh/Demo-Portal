namespace DemoPortfal_IceCodeTest.Data
{

    public class LoginService{
        public Boolean LoggedIn {get; private set;} = false; 
        public Boolean isEmail( string str){
        return str == "admin@gmail.com";
        }

        public Boolean isPassword( string str){
            return str == "12345";
        }

        public Boolean checkCredentials ( string email, string password){
            if( email == "admin@gmail.com" && password == "12345"){
                LoggedIn = true;
            }else{
                LoggedIn = false;
            }
            return LoggedIn;
        }
    }
}