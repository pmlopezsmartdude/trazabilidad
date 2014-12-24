<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="impresoras.aspx.cs" Inherits="Mainsite.Admsistema.impresoras" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Content/workarea.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
        <asp:TabContainer ID="Tabcontainer1" runat="server" ActiveTabIndex="0" Font-Names="Century Gothic" Font-Size="Small" style="height:100%;">
            <asp:TabPanel runat="server" HeaderText="Impresoras Sistema" ID="Tabpanel1" Font-Names="Century Gothic" Font-Size="X-Small" style="width:100%;">
            <ContentTemplate>
            <asp:Table ID="Impresoras" runat="server" style="display:block; width:100%; border:none; margin:0; padding:0; height:100%;" Height="430px" Font-Names="Century Gothic" Font-Size="X-Small" BackColor="#CCCCCC">
            <asp:TableRow style="width:100%;" runat="server">
            <asp:TableCell style="width:100%;" runat="server">
            <asp:GridView ID="printergrid" runat="server" AllowPaging="True" CellPadding="4" 
                    ForeColor="#333333" GridLines="Vertical" AutoGenerateColumns="false"
                    DataKeyNames="nombreimp" Font-Names="Century Gothic" Font-Size="Small"
                    onpageindexchanging="impresoras_PageIndexChanging"
                    HorizontalAlign="Center" style="width:800px">
    
    <Columns>
    <asp:BoundField DataField="nombreimp" HeaderText="Nombre" />
    <asp:BoundField DataField="marcaimp" HeaderText="Marca" />
    <asp:BoundField DataField="ipimp" HeaderText="ip" />
    </Columns>
<AlternatingRowStyle backcolor="White" />
<Columns>
<asp:CommandField ShowSelectButton="True" ButtonType="Button" >
<ControlStyle CssClass="btnstyle"></ControlStyle>

<ItemStyle CssClass="btnstyle"></ItemStyle>
</asp:CommandField>
</Columns>

<EditRowStyle BackColor="#7C6F57" />

<FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />

<HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />

<PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />

<RowStyle BackColor="#E3EAEB" />

<SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />

<SortedAscendingCellStyle BackColor="#F8FAFA" />

<SortedAscendingHeaderStyle BackColor="#246B61" />

<SortedDescendingCellStyle BackColor="#D4DFE1" />

<SortedDescendingHeaderStyle BackColor="#15524A" />
</asp:GridView>
                <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
</asp:TableCell>
            </asp:TableRow>
            </asp:Table>
            </ContentTemplate>
            </asp:TabPanel>
        </asp:TabContainer>
    </form>
</body>
</html>
