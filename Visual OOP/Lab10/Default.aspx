<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-top: 0px;
        }
        .auto-style2 {
            width: 237px;
            text-align: right;
        }
        .auto-style5 {
            width: 237px;
            text-align: right;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Home Page<br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">Quan-TITTY:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="QuantityTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="QuantityTextBoxRFV" runat="server" ControlToValidate="QuantityTextBox" ErrorMessage="You must enter a quantity!" ForeColor="#A6182E">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="QuantityRangeValidator" runat="server" ControlToValidate="QuantityTextBox" ErrorMessage="Must be between 1-100" ForeColor="#A6182E" MaximumValue="100" MinimumValue="1" Type="Integer">1-100</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">TIT-le:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TitleTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Price:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="PriceTextBox" runat="server" Height="22px" Width="128px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="PriceRFV" runat="server" ControlToValidate="PriceTextBox" ErrorMessage="Must enter a price!" ForeColor="#A61830">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="PriceRangeValidator" runat="server" ControlToValidate="PriceTextBox" ErrorMessage="Enter a valid dollar value" ForeColor="#A6182F" MaximumValue="1000000" MinimumValue="0" Type="Currency">$ X.xx</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Extended Price:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="ExtPriceTextBox" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">15% Discount:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="DiscountTextBox" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Discounted Price:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="DiscoutedPriceTextBox" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="ErrorLabel" runat="server" ForeColor="#97162C"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td>
                    <asp:Button ID="SubmitButton" runat="server" Text="SUBMIT!!!" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="ClearButton" runat="server" CausesValidation="False" Text="Clear" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <br />
        <asp:HyperLink ID="ContactUsHyperLink" runat="server" NavigateUrl="~/ContactUs.aspx">Contact Us</asp:HyperLink>
    </form>
</body>
</html>
