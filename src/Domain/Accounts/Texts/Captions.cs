﻿namespace Habitat.Accounts.Texts
{
  using Sitecore.Globalization;

  public static class Captions
  {
    public static string Email => Translate.Text("Email");
    public static string E_mail => Translate.Text("E-mail");

    public static string Login => Translate.Text("Login");

    public static string Logout => Translate.Text("Logout");

    public static string Password => Translate.Text("Password");

    public static string ConfirmPassword => Translate.Text("Confirm password");

    public static string Register => Translate.Text("Register");

    public static string ResetPassword => Translate.Text("Reset password");

    public static string ResetPasswordInfo => Translate.Text("The new password will be sent to your e-mail.");

    public static string ResetPasswordSuccess => Translate.Text("Your password has been reset.");
  }
}