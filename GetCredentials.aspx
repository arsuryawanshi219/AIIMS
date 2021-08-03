<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetCredentials.aspx.cs" Inherits="GetCredentials" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>MOCK</title>
    <link rel="shortcut icon" type="image/x-icon" href="../headers/lo.ico" />
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />

         <script type="text/javascript">
             langid = 'en-US';
             userName = 'Guest';
             ToggleURL = "FrmEntryForm.aspx";
             logindt = "Date";
             Header = "subheaderblank()";
             ServerName = "Ctrl";
             timeServer = new Date;
             lblHome = "Home";
             lblAboutMPOnline = "About Mahatransco";
             lblContactUs = "Contact us";
             lblLogin = "Login";

    </script>
    <script src="../Portal/headers/MPOnlineHeader/jquery.js" type="text/javascript"></script>
    <script src="../Portal/headers/MPOnlineHeader/slide.js" type="text/javascript"></script>
    <script src="../Portal/headers/MPOnlineHeader/SevicesLogo.js" type="text/javascript"></script>

    <script src="../Portal/headers/MPOnlineHeader/Kiosk.js" type="text/javascript"></script>
    <script src="../Portal/headers/MPOnlineHeader/Ticker.js" type="text/javascript"></script>
    <script src="../Portal/headers/MPOnlineHeader/TimeTick.js" type="text/javascript"></script>
    <script src="../Portal/headers/MPOnlineHeader/Zoom.js" type="text/javascript"></script>
    <link href="../Css/CalendarControl.css" rel="stylesheet" type="text/css" />
    <script src="../Css/CalendarControl.js" language="javascript" type="text/javascript"></script>
    <script type="text/javascript">        var MsgDiv = document.createElement("div"); MsgDiv.id = "divclMsg"; document.body.appendChild(MsgDiv);</script>
    <script type="text/javascript">

        function ShowCurrentTime() {

            var dt = new Date();

            document.getElementById("LblTime").innerHTML = dt.toDateString() + "  " + dt.toLocaleTimeString();

            window.setTimeout("ShowCurrentTime()", 1000); // Here 1000(milliseconds) means one 1 Sec  

        }

    </script>

    <style type="text/css">
        .auto-style1 {
            width: 9%;
        }
        .style1
        {
            height: 22px;
        }
    </style>
</head>
<body>
        <form id="form1" runat="server">
        <div>
           
             <table style="background-color:white;text-align:center" width="90%">
                <tr>
                    <td class="auto-style1">
                        <img src="DDUUlogo.jpg" style="margin-left: 99px" />
                    </td>
                      
                                  
                        </div>
                       
                    </td>
                </tr>
              
            </table>
            <table style="background-color:white" align="center" width="80%">
                
                <tr>
                <td></td><td></td><td></td><td></td><td></td></tr>
                <tr>
                <td style="text-align:center" width="100%"></td></tr>
               <tr>
                <td style="text-align:center" width="100%"><asp:Button ID="btnclick" runat="server" 
                        Text="Click here to get Login Credentials" BackColor="#0404F2" 
                        ForeColor="white" Font-Bold="true" Height="50px" onclick="btnclick_Click"/></td><br />
                    </tr>
             <tr>
                <td style="text-align:center" width="100%"></td><br />
                    </tr>
					     <tr>
                <td style="text-align:center" width="100%">    <div id="divdetails" style="font-size:18px" runat="server" visible="false">
               
               Roll No:  AUMOCK<asp:Label ID="lblMock" runat="server" Text=""></asp:Label><br />
               Password: 
			     
                    <asp:Label ID="lblpassword" runat="server" Text="1234"></asp:Label><br />
                    PIN: 
                    <asp:Label ID="lblpin" runat="server" Text="1111"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="btnexam" runat="server" 
                        Text="Start Exam" BackColor="#0404F2" 
                        ForeColor="white" Font-Bold="true" Height="50px" onclick="btnexam_Click"/>
						<br />
                 
                </div></td><br />
                    </tr>
					
               
            
                       
                       </td></tr>
                
            </table>

        </div>
    </form>
       <script type="text/javascript" src="../Portal/headers/creditsfootermp.js"></script>
</body>
</html>
