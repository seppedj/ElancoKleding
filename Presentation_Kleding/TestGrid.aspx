<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestGrid.aspx.cs" Inherits="Presentation_Kleding.TestGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="gvTest" runat="server">
            <Columns>
                <asp:ImageField DataImageUrlField="Foto">
                    <ControlStyle Height="200px" Width="200px" />
                </asp:ImageField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
