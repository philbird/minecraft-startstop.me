<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">


<h1>Upload your stats</h1>
			<span id="slogan2">plain and simple open source minecraft stats uploader</span>



<div class="box">
				<div class="box_inner">	
					
					<h2>What you need to know</h2>
					<p>
                        To publish your stats, you need a <a href="http://www.startstop.me" target=_blank>Startstop.me</a> account, which is free. You should register here first as you need the registration details
                        to upload the stats. 
                    </p>		

                    <p>
                        Once you have an account enter the startstop emailaddress and password below and then click BROWSE, to locate your minecraft stats file, this is located in the user directory, and might not be visible to you
                        unless you have "hidden files" shown. More about that shortly, however, for now go here; 
                        <br />
                        C:\Users\YOURUSERNAME\AppData\Roaming\.minecraft\stats
                        <br />

                        And look for the .DAT file in this directory. Once you have it click upload file and away you go. 
                    </p>

				</div>
			</div>

            <p>

<table border=0>
    <tr>
        <td>Registered Email</td>
        <td> <asp:TextBox ID="uxEmailAddress" runat=server></asp:TextBox></td>
    </tr>

    <tr>
        <td> Registered Password</td>
        <td> <asp:TextBox ID="uxPassword" runat=server TextMode=Password></asp:TextBox></td>
    </tr>

    <tr>
        <td>Minecraft stats .dat file</td>
        <td>  <asp:FileUpload ID="uxUpload" runat=server  />
    
 
    </tr>

    <tr>
        <td></td>
        <td>   <asp:Button ID="uxDoUpload" runat=server Text="Upload" 
    onclick="uxDoUpload_Click" /></td></td>
    </tr>


</table>
</p>

</asp:Content>

