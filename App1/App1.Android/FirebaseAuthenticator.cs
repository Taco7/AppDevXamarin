﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Auth;

public class FirebaseAuthenticator : App1.Models.IFirebaseAuthenticator
{
    public async Task<string> LoginWithEmailPassword(string email, string password)
    {
        var user = await FirebaseAuth.Instance.
                        SignInWithEmailAndPasswordAsync(email, password);
        var token = await user.User.GetIdTokenAsync(false);
        return token.Token;
    }
}