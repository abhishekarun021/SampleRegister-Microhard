<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsForm.aspx.cs" Inherits="Student.DetailsForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Underline="True" Text="Student Details"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Student_id" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCommand="GridView1_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="Student_id" HeaderText="Student Id" />
                            <asp:BoundField DataField="Student_code" HeaderText="Student Code" />
                            <asp:BoundField DataField="Student_Name" HeaderText="Student Name" />
                            <asp:BoundField DataField="Student_Address" HeaderText="Address" />
                            <asp:BoundField DataField="Email" HeaderText="Email" />
                            <asp:BoundField DataField="Mobile_Number" HeaderText="Phone Number" />
                            <asp:BoundField DataField="Join_Date" HeaderText="Joined Date" />
                            <asp:CommandField ShowEditButton="True" />
                            <asp:CommandField ShowDeleteButton="True" />
                            <asp:CommandField SelectText="Print" ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <%--<script>
            function printRow(studentId, studentName, address, email, phoneNumber, joinDate) {
                var data = "Student ID: " + studentId + "\n" +
                    "Student Name: " + studentName + "\n" +
                    "Address: " + address + "\n" +
                    "Email: " + email + "\n" +
                    "Mobile: " + phoneNumber + "\n" +
                    "Joined On: " + joinDate + "\n";

                var windowName = "Print Window";
                var windowOptions = "height=200,width=300";
                var printWindow = window.open("PrintPage.aspx?data=" + encodeURIComponent(data), windowName, windowOptions);
                printWindow.focus();
            }
        </script>--%>
        <div>
        </div>
    </form>
</body>
</html>
