
public class UserLoginVM{
    public required string Account{get;set;} // Account : email,username,phonenumber
    public required string Password{get;set;} 
}


public class UserLoginResultVM{
    public string Account{get;set;}
    public string AccessToken{get;set;}
}

