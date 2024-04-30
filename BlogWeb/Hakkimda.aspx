<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Hakkimda.aspx.cs" Inherits="BlogWeb.Hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label ID="Label1" runat="server" Text="Adınız"></asp:Label>
                <asp:TextBox ID="TextBoxAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label2" runat="server" Text="Soyadınız"></asp:Label>
                <asp:TextBox ID="TextBoxSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label3" runat="server" Text="Adres"></asp:Label>
                <asp:TextBox ID="TextBoxAdres" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label4" runat="server" Text="Mail"></asp:Label>
                <asp:TextBox ID="TextBoxMail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label5" runat="server" Text="Telefon"></asp:Label>
                <asp:TextBox ID="TextBoxTelefon" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label6" runat="server" Text="Kısa Not"></asp:Label>
                <asp:TextBox ID="TextBoxKısaNot" runat="server" CssClass="form-control" TextMode="MultiLine" Height="100px"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label7" runat="server" Text="Fotğraf"></asp:Label>
                <asp:TextBox ID="TextBoxFotograf" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="GÜNCELLE" CssClass="btn btn-success" OnClick="Button1_Click1" />
    </form>

</asp:Content>
