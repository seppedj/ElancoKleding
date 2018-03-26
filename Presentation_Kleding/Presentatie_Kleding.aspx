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
																			
                                    	<asp:Button ID="btnHemd" runat="server" Text="Hemd" BackColor="#010429" Font-Bold="False" Font-Names="Verdana" ForeColor="White" />
																			
                                    </div>
                                </div>
                                <img src="img\VBhemdVierkant.png" alt="">
                            </div>
							<div class="container">
								<div class="overlay">
									<div class="text">
									 <button id="btnKraag" type ="button">Kraag</button>
									</div>
								</div>
								<img src="img\klassiek_1_deligVierkant.png" alt="">
							</div>
							<div class="container">
								<div class="overlay">
									<div class="text">
										Borstzak
									</div>
								</div>
								<img src="img\borstzakVierkant.png" alt="">
							</div>
							<div class="container">
								<div class="overlay">
									<div class="text">
										Knoopsluiting
									</div>
								</div>
								<img src="#" alt="">
							</div>
							<div class="container">
								<div class="overlay">
									<div class="text">
										Knoop
									</div>
								</div>
								<img src="#" alt="">
							</div>
							<div class="container">
								<div class="overlay">
									<div class="text">
										Epaulet
									</div>
								</div>
								<img src="img\schouderepauletEvenwijdigVierkant.png" alt="">
							    
							</div>
							<div class="container">
								<div class="overlay">
									<div class="text">
										Mouw
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
								<asp:ImageButton ID="imgbtnTEST" runat="server" Height="33px" />
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
