$(document).ready(function () {

	slideShow('#photos');
	kwaliteitslabels();

	// 	$('.showslide').toggle(
	// 		function() {
	// 			$('#txt, #content, #bg, #nav, #subnav').animate({marginTop: "-500px"});
	// 			$(this).empty().append('Sluit foto\'s');
	// 		},
	// 		function() {
	// 			$('#txt, #content, #bg, #nav, #subnav').animate({marginTop: "0px"});
	// 			$(this).empty().append('Bekijk foto\'s');			
	// 		}
	// 	);

	$('.showslide').click(
		function () {
			$('#txt, #content, #bg, #nav, #subnav').fadeOut(200);
			$(this).hide();
			$('.hideslide').show();
			return false;
		});

	$('.hideslide').click(
		function () {
			$('#txt, #content, #bg, #nav, #subnav').fadeIn(200);
			$(this).hide();
			$('.showslide').show();
			return false;
		});

});

function slideShow(element) {
	setInterval(function () {
		if ($(element).children('img:visible:eq(0)').prev().size() > 0) {
			$(element).children('img:visible:eq(0)').prev().show();
			$(element).children('img:visible:eq(1)').fadeOut(2000);
		} else {
			$(element).children('img:last').fadeIn(2000, function () {
				$(element).children('img:visible').not(':last').fadeOut(2000);
			});
		}
	}, 5000);
}

function kwaliteitslabels() {

	$('.kwaliteitslabel').click(function () {
		//window.alert('klik');
		if (!$(this).is('.current')) {

			var div = $(this).attr('href');

			$('.kwaliteitslabeldiv:visible').slideUp(500, function () {
				$(div).slideDown();
			});

			$('.kwaliteitslabel').removeClass('current');
			$(this).addClass('current');

			return false;

		} else {
			return false;
		}

	});
}