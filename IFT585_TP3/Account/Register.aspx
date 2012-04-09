<%@ Page Title="S'inscrire" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Register.aspx.cs" Inherits="IFT585_TP3.Account.Register" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
                    <h2>
                        Créer un nouveau compte
                    </h2>
                    <p>
                        Utilisez le formulaire ci-dessous pour créer un nouveau compte.
                    </p>
                    <p>
                        Les mots de passe doivent comporter au minimum <%= Membership.MinRequiredPasswordLength %> caractères.
                    </p>
                    <span class="failureNotification">
                        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
                    </span>
                    <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" CssClass="failureNotification" 
                         ValidationGroup="RegisterUserValidationGroup"/>
                    <div class="accountInfo">
                        <fieldset class="register">
                            <legend>Informations de compte</legend>
                            <p>
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nom d'utilisateur :</asp:Label>
                                <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                                     CssClass="failureNotification" ErrorMessage="Un nom d'utilisateur est requis." ToolTip="Un nom d'utilisateur est requis." 
                                     ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                            </p>
                            <p>
                            <asp:Label ID="lblCheminAcces" runat="server" AssociatedControlID="txtCheminAcces">Chemin d'accès à votre dossier :</asp:Label>
                            <asp:TextBox ID="txtCheminAcces" runat="server" CssClass="textEntry"></asp:TextBox><img src="../Images/Point_D_Interrogation.png" width="20px" height="20px" title="Ce chemin d'accès peut ressembler à 'C:\monDossier'. Il permet d'indiquer l'endroit où les fichiers partagés et les fichiers à partager seront créés." />
                                <asp:RequiredFieldValidator ID="CheminAccesRequis" runat="server" ControlToValidate="txtCheminAcces" 
                                     CssClass="failureNotification" ErrorMessage="Un chemin du dossier de base est requis." ToolTip="Un chemin du dossier de base est requis." 
                                     ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                            
                           
                            </p>
                            <p>
                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Mot de passe :</asp:Label>
                                <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" 
                                     CssClass="failureNotification" ErrorMessage="Un mot de passe est requis." ToolTip="Un mot de passe est requis." 
                                     ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirmer le mot de passe :</asp:Label>
                                <asp:TextBox ID="ConfirmPassword" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ControlToValidate="ConfirmPassword" CssClass="failureNotification" Display="Dynamic" 
                                     ErrorMessage="La confirmation du mot de passe est requise." ID="ConfirmPasswordRequired" runat="server" 
                                     ToolTip="La confirmation du mot de passe est requise." ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" 
                                     CssClass="failureNotification" Display="Dynamic" ErrorMessage="Le mot de passe et le mot de passe de confirmation doivent correspondre."
                                     ValidationGroup="RegisterUserValidationGroup">*</asp:CompareValidator>
                            </p>
                        </fieldset>
                        <p class="submitButton">
                            <asp:Button ID="CreateUserButton" runat="server" OnClick="CreateUser" Text="Créer un utilisateur" 
                                 ValidationGroup="RegisterUserValidationGroup"/>
                        </p>
                    </div>
</asp:Content>
