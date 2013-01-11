﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Relacoes.aspx.cs" Inherits="Registado_Relacoes" MasterPageFile="~/Site.Master" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>



<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <section id="loginForm">
        <h2>titulo</h2>
    <asp:Table runat="server" meta:resourcekey="TableResource1">
        <asp:TableRow meta:resourcekey="TableRowResource1">
            <asp:TableCell meta:resourcekey="TableCellResource1">
                asd
            </asp:TableCell>
            <asp:TableCell meta:resourcekey="TableCellResource2">

                asdfsa
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Label ID="Label4" runat="server" Text="Procurar Amigos:" meta:resourcekey="Label4Resource1"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" meta:resourcekey="TextBox1Resource1"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Procurar" OnClick="Button1_Click" meta:resourcekey="Button1Resource1" />
    <br />
    <asp:GridView ID="GridView1" SelectedRowStyle-BackColor="Red" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" >
        <Columns>
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" meta:resourcekey="BoundFieldResource1" />
            <asp:BoundField DataField="Nick" HeaderText="Nick" SortExpression="Nick" meta:resourcekey="BoundFieldResource2" />
            <asp:ImageField DataImageUrlField="Avatar" meta:resourcekey="ImageFieldResource1">
            </asp:ImageField>
            <asp:CommandField ButtonType="Button" HeaderText="Selecionar" ShowHeader="True" ShowSelectButton="True" meta:resourcekey="CommandFieldResource1" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Tags da Relação:" meta:resourcekey="Label5Resource1"></asp:Label>
    <br />
<asp:TextBox ID="TextBoxTag" runat="server" meta:resourcekey="TextBoxTagResource1"></asp:TextBox>
<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Juntar" meta:resourcekey="Button3Resource1" />
<asp:DropDownList ID="DropDownTags" runat="server" meta:resourcekey="DropDownTagsResource1">
</asp:DropDownList>
<br />
<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Força" meta:resourcekey="Label1Resource1"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownForca" runat="server" meta:resourcekey="DropDownForcaResource1">
    <asp:ListItem meta:resourcekey="ListItemResource1">1</asp:ListItem>
    <asp:ListItem meta:resourcekey="ListItemResource2">2</asp:ListItem>
    <asp:ListItem meta:resourcekey="ListItemResource3">3</asp:ListItem>
    <asp:ListItem meta:resourcekey="ListItemResource4">4</asp:ListItem>
    <asp:ListItem meta:resourcekey="ListItemResource5">5</asp:ListItem>
</asp:DropDownList>
<br />
<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Enviar" meta:resourcekey="Button2Resource1" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Pedidos de Amizades Enviados:"></asp:Label>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID ="SqlDataSource2" meta:resourcekey="GridView2Resource1">
        <Columns>
            <asp:ImageField DataImageUrlField="Avatar" meta:resourcekey="ImageFieldResource2"></asp:ImageField>
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" meta:resourcekey="BoundFieldResource3" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" meta:resourcekey="BoundFieldResource4" />
            </Columns>
    </asp:GridView>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Lista de Amigos:" meta:resourcekey="Label2Resource1"></asp:Label>
    <br />
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID ="SqlDataSource3"  OnSelectedIndexChanged="GridView3_SelectedIndexChanged" >
        <Columns>
            <asp:ImageField DataImageUrlField="Avatar" meta:resourcekey="ImageFieldResource3"></asp:ImageField>
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" meta:resourcekey="BoundFieldResource5" />
            <asp:CommandField SelectText="Remover" ShowSelectButton="True"  />
            </Columns>
    </asp:GridView>
<br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ARQSI22ConnectionString %>">
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ARQSI22ConnectionString %>">
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ARQSI22ConnectionString %>">
    </asp:SqlDataSource>
        <br />
        <br />
    <asp:Label ID="Label6" runat="server" Text="Pedidos de Amizades recebidos:"></asp:Label>
        <br />
    <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataSourceID ="SqlDataSource4"  OnSelectedIndexChanged="GridView4_SelectedIndexChanged" >
        <Columns>
            <asp:ImageField DataImageUrlField="Avatar"></asp:ImageField>
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
            <asp:CommandField SelectText="Aceitar" ShowSelectButton="True"  />
            </Columns>
    </asp:GridView>
        <br />
        <br />
    <asp:Label ID="Label7" runat="server" Text="Tags da Relação:"></asp:Label>
        <br />
<asp:TextBox ID="TextBoxTag0" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Juntar" />
<asp:DropDownList ID="DropDownTags0" runat="server">
</asp:DropDownList>
        <br />
<asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Large" Text="Força"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownForca0" runat="server">
    <asp:ListItem>1</asp:ListItem>
    <asp:ListItem>2</asp:ListItem>
    <asp:ListItem>3</asp:ListItem>
    <asp:ListItem>4</asp:ListItem>
    <asp:ListItem>5</asp:ListItem>
</asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ARQSI22ConnectionString %>">
    </asp:SqlDataSource>
    <br />
    <br />
        </section> <section id="Section1">
        <h2>Pessoas que possa conhecer...</h2>

        </section>
</asp:Content>

    
