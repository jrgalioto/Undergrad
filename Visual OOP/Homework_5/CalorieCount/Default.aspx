<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 159px;
        }
        .auto-style3 {
            width: 159px;
            text-align: right;
        }
        .auto-style4 {
            width: 159px;
            text-align: right;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
    </style>
</head>
<body style="color: white; background-color: #690717; font-family: Lato, sans-serif;">
    <form id="form1" runat="server">
    <div style="text-align: center; font-weight: 700">
    
        <h2>Calorie Counter</h2>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <h3>Fat:</h3>
                </td>
                <td>
                    <address>
                        <asp:TextBox ID="FatTextBox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FatTextBox" ErrorMessage="Must Enter A Number">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="FatTextBox" ErrorMessage="0-1000" MaximumValue="1000" MinimumValue="0" Type="Integer">0-1000</asp:RangeValidator>
                    </address>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <h3>Carbs:</h3>
                </td>
                <td>
                    <address>
                        <asp:TextBox ID="CarbsTextBox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="CarbsTextBox" ErrorMessage="Must Enter a Number">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="CarbsTextBox" ErrorMessage="0-1000" MaximumValue="1000" MinimumValue="0" Type="Integer">0-1000</asp:RangeValidator>
                    </address>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <h3>Protein:</h3>
                </td>
                <td>
                    <address>
                        <asp:TextBox ID="ProteinTextBox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ProteinTextBox" ErrorMessage="Must Enter a Number">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="ProteinTextBox" ErrorMessage="0-1000" MaximumValue="1000" MinimumValue="0" Type="Integer">0-1000</asp:RangeValidator>
                    </address>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <h3>Total Calories:</h3>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TotalCaloriesTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td>
                    <asp:Label ID="ErrorLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="CalculateButton" runat="server" Text="Calculate" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="ClearButton" runat="server" CausesValidation="False" Text="Clear" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
