<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MidTermExam.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="pnlFindPerson" runat="server">
                <asp:DropDownList ID="ddlFindPerson" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlFindPerson_SelectedIndexChanged"></asp:DropDownList>
            </asp:Panel>
            <asp:Panel ID="pnlCreateMeal" runat="server">
                <asp:Table ID="tblCreateMeal" runat="server">
                    <asp:TableRow>
                        <asp:TableCell>Enter the Day.</asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtDay" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Enter the Meal of Day.</asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtMealDay" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Enter the Meal Description.</asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtMealDescription" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Enter the Calories.</asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtCalories" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Enter the Fat.</asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtFat" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Enter the Carbs.</asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtCarbs" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Button ID="btnSaveMeal" Text="Save Meal" runat="server" OnClick="btnSaveMeal_Click"/></asp:TableCell>
                        <asp:TableCell><asp:Button ID="btnRecordMeals" Text="Record Meals" runat="server" OnClick="btnRecordMeals_Click"/></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </asp:Panel>
            <br />
            <asp:Panel ID="pnlShowMeal" runat="server"><asp:Panel ID="pnlFindPerson2" runat="server">
                <asp:DropDownList ID="ddlFindPerson2" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlFindPerson2_SelectedIndexChanged"></asp:DropDownList>
            </asp:Panel>
                <asp:Button ID="btnFindPerson" runat="server" Text="Meal for Person" OnClick="btnFindPerson_Click" />
                <asp:GridView ID="gvShowMeal" runat="server" Visible ="false">
                </asp:GridView>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
