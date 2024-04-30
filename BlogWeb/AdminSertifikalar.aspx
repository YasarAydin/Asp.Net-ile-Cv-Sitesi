<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminSertifikalar.aspx.cs" Inherits="BlogWeb.AdminSertifikalar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>SERTİFİKA</th>
                <th>İŞLEMLER</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <itemtemplate>
                        <tr>
                            <th><%# Eval("ID") %></th>
                            <th><%# Eval("SERTIFIKAAD") %></th>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "AdminSertifikaSil.aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">
                                    Sil
                                </asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "AdminSertifikaGuncelle.aspx?ID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success">
                                    Güncelle
                                </asp:HyperLink>
                            </td>
                        </tr>
                    </itemtemplate>
                </asp:Repeater>
            </tbody>
        </table>

        <asp:HyperLink NavigateUrl="~/AdminSertifikaEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-success">SERTİFİKA EKLE</asp:HyperLink>

    </form>

</asp:Content>
