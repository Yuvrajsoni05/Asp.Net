<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AJAX_CRUD.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
<td>Name</td>
<td><input type="text" id="t1" /></td>
                </tr>
                
                   <tr>
<td>city</td>
<td><input type="text" id="t2" /></td>
                </tr>

                                   <tr>

<td><input type="button" id="b1" value="insert" onclick="insert();" /></td>
<td><input type="button" id="b2" value="display" onclick="display();" /></td>
<td><input type="button" id="btn3" value="Delete" onclick="delete1();" /></td>   
          <td><input type="button" id="btn3" value="Update" onclick="update1();" /></td>                             
                </tr>

            </table>
            <div id ="d1">

            </div>
        </div>
    </form>

    <script type="text/javascript">
        function insert() {
            var name = document.getElementById("t1").value;
            var city = document.getElementById("t2").value;

            var xmlhttp = new XMLHttpRequest();
            xmlhttp.open("GET", "insert.aspx?nm=" + name + "&ct=" + city + "&opr=insert", false);
            xmlhttp.send(null);

            var name = document.getElementById("t1").value = "";
            var city = document.getElementById("t2").value = "";
            alert('Recored Inserted');
        }
        function display() {
            var xmlhttp = new XMLHttpRequest();
            xmlhttp.open("GET", "insert.aspx?opr=display", false)
            xmlhttp.send(null);

            document.getElementById("d1").innerHTML = xmlhttp.responseText;
        }
        function delete1() {
            var name = document.getElementById("t1").value;
            var xmlhttp = new XMLHttpRequest();
            xmlhttp.open("GET", "insert.aspx?nm=" + name + "&opr=delete1", false);
            xmlhttp.send(null);

            var name = document.getElementById("t1").value = "";
            alert('DELETE');

        }
        function update1() {
            var oldname = document.getElementById("t1").value;
            var newname = document.getElementById("t2").value;


            var xmlhttp = new XMLHttpRequest();
            xmlhttp.open("GET", "insert.aspx?oldname=" + oldname + "&newname=" + newname + "&opr=update1", false);
            xmlhttp.send(null);

            document.getElementById("t1").value = "";
            document.getElementById("t2").value = "";


            alert('Update');

        }

    </script>
</body>
</html>
