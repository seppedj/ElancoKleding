<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Presentatie_Kleding.aspx.cs" Inherits="Presentation_Kleding.Presentatie_Kleding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kledingconfigurator</title>
	<meta http-equiv="content-type" content="text/html" charset="utf-8" />
	<meta http-equiv="Content-Language" content="nl" />
	<meta name="author" content="Tallieu &amp; Tallieu - Deinze, Belgi&euml;" />
	<meta name="robots" content="All" />
	<meta name="revisit-after" content="14 days" />
	<meta name="geo.placename" content="Aarsele, Belgi&euml;" />
	<meta name="geo.country" content="BE" />
	<meta name="copyright" content="Tallieu &amp; Tallieu - Deinze, Belgi&euml;" />
	<meta name="description" content="Elanco - uniformhemden, uniformbloezen, hemden, bloezen, borduren - contact / algemene gegevens"
	/>
	<meta name="keywords" content="elanco" />
	<meta name="rating" content="general" />
	<meta name="MSSmartTagsPreventParsing" content="true" />
	<meta http-equiv="imagetoolbar" content="false" />
	<script type="text/javascript" src="script/jquery-1.3.2.min.js"></script>
	<script type="text/javascript" src="script/init.js"></script>
    

    <link rel="stylesheet" href="Opmaak.css" runat="server" />
</head>
<body>
	<form id="form1" runat="server">
	<div id="bg">
	</div>
	<div id="wrapper">
		<div id="subwrapper">
			<div id="photos">
				<img style="display: none;" src="img/photo2.jpg" />
				<img style="display: none;" src="img/photo3.jpg" />
				<img style="display: none;" src="img/photo7.jpg" />
				<img style="display: none;" src="img/photo12.jpg" />
				<img style="display: none;" src="img/photo10.jpg" />
				<img style="display: none;" src="img/photo9.jpg" />&nbsp;
			</div>
			<div id="content">
				<div id="txt">
					<h2>Kledingconfigurator</h2><asp:Button ID="btnTest" runat="server" Text="Test" OnClick="btnTest_Click"/>
                    <asp:Label ID="lblTest" runat="server" Text="..."></asp:Label>
					<div class="conf">
						<div class="ItemKeuze">
                            <div class="container">
                                <div class="overlay" >
                                    <div class="text" >	
																			
                                    	<asp:Button ID="btnHemd" runat="server" Text="Hemd" BackColor="#010429" BorderColor="#010429" BorderWidth="30px" Font-Bold="False" Font-Names="Verdana" ForeColor="White" Height="100px" OnClick="btnHemd_Click1" Width="97px" />
																			
                                    </div>
                                </div>
                                <img src="img\VBhemdVierkant.png" alt="">
                            </div>
							<div class="container">
								<div class="overlay">
									<div class="text">
										<asp:Button ID="btnKraag" runat="server" Text="Kraag" BackColor="#010429" BorderColor="#010429" ForeColor="White" Height="97px" OnClick="btnKraag_Click" Width="94px" />
									</div>
								</div>
								<img src="img\klassiek_1_deligVierkant.png" alt="">
							</div>
							<div class="container">
								<div class="overlay">
									<div class="text">
										
										<asp:Button ID="btnBortszak" runat="server" Height="100px" Text="Borstzak" Width="86px" BackColor="#010429" BorderColor="#010429" ForeColor="White" OnClick="btnBortszak_Click" />
										
									</div>
								</div>
								<img src="img\borstzakVierkant.png" alt="">
							</div>
							<div class="container">
								<div class="overlay">
									<div class="text">
										<asp:Button ID="btnKnoopsluiting" runat="server" Text="Knoopsluiting" BackColor="#010429" BorderColor="#010429" ForeColor="White" Height="96px" Width="96px" OnClick="btnKnoopsluiting_Click" />
									</div>
								</div>
								<img src="#" alt="">
							</div>
							<div class="container">
								<div class="overlay">
									<div class="text">
										<asp:Button ID="btnKnoop" runat="server" Height="95px" Text="Knoop" Width="95px" BackColor="#010429" BorderColor="#010429" ForeColor="White" />
									</div>
								</div>
								<img src="#" alt="">
							</div>
							<div class="container">
								<div class="overlay">
									<div class="text">
										<asp:Button ID="btnEpaulet" runat="server" Text="Epaulet" BackColor="#010429" BorderColor="#010429" ForeColor="White" Height="95px" Width="94px" OnClick="btnEpaulet_Click" />
									</div>
								</div>
								<img src="img\schouderepauletEvenwijdigVierkant.png" alt="">
							    
							</div>
							<div class="container">
								<div class="overlay">
									<div class="text">
										<asp:Button ID="btnMouw" runat="server" BackColor="#010429" BorderColor="#010429" ForeColor="White" Text="Mouw" Height="85px" Width="90px" OnClick="btnMouw_Click" />
									</div>
								</div>
								<img src="img\polsboord_afgerondVierkant.png" alt="">
							</div>
							<div class="container">
								<div class="overlay">
									<div class="text">
										Borduur
									</div>
								</div>
								<img src="#" alt="">
							</div>
						</div>
						<div class="voorbeeld">
							<div class="hemd">
							</div>
							<div class="kraag">
								<asp:ImageButton ID="imgbtnTEST" runat="server" Height="33px" OnClick="imgbtnTEST_Click" />
							    <asp:Button ID="btnKorteMouw" runat="server" OnClick="btnKorteMouw_Click" Text="Korte Mouw" />
                                <asp:Button ID="btnLangeMouw" runat="server" OnClick="btnLangeMouw_Click" Text="Lange Mouw" />
                                <asp:Button ID="btnMouwsplit" runat="server" OnClick="btnMouwsplit_Click" Text="MouwSplit" />
                                <asp:Button ID="btnPolsboord" runat="server" OnClick="btnPolsboord_Click" Text="Polsboord" />
							    <asp:ListBox ID="lstUitvoer" runat="server" Height="108px" Width="285px"></asp:ListBox>
							</div>
							<div class="borstzak">
							</div>
							<div class="knoopsluiting">
							</div>
							<div class="knoop">
							</div>
							<div class="epaulet">
							</div>
							<div class="mouw">
							</div>
							<div class="borduur">
							</div>
						</div>
					</div>
				</div>
				<img src="img/photo11.jpg" /></div>
		</div>
		<ul id="nav">
			<li><a class="none" href="http://www.elanco.be/nl/index.php" title="Over Elanco">Over Elanco</a></li>
			<li><a class="none" href="http://www.elanco.be/nl/artikelen.php" title="Artikelen">Artikelen</a></li>
			<li><a class="none" href="http://www.elanco.be/nl/productie.php" title="Productie">Productie</a></li>
			<li><a class="none" href="http://www.elanco.be/nl/kwaliteitslabels.php" title="Kwaliteitslabels">Kwaliteitslabels</a></li>
			<li><a class="none" href="http://www.elanco.be/nl/contact.php" title="Contact">Contact</a></li>
			<li><a class="active" href="#" title="Kledingconfigurator">Kledingconfigurator</a></li>
		</ul>
	</div>

        <br />
        <br />
    </form>
</body>

</html>
