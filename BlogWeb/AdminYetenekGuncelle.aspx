<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminYetenekGuncelle.aspx.cs" Inherits="BlogWeb.AdminYetenekGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
                <asp:TextBox ID="TextBoxID" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label2" runat="server" Text="YETENEK"></asp:Label>
                <asp:TextBox ID="TextBoxYetenek" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
        </div>
        <br />
        <asp:Button ID="ButtonYetenekGuncelle" runat="server" Text="GÜNCELLE" CssClass="btn btn-success" OnClick="ButtonYetenekGuncelle_Click" />

    </form>

</asp:Content>
