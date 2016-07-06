function contactBox(){
	if($('.contactBox').hasClass('visible'))
	{
		hideContactBox();
	}
	else{
		showContactBox();
	}
};

function showContactBox(){
	//Scroll window
    $('html, body').animate({ scrollTop: '160' });

	$('.contactBox').addClass('visible');
	$('.rightHeader .contactInfo').addClass('contactInfoActive');
	$('.contactBox').slideDown('slow', function() {});
}

function hideContactBox(){
	$('.contactBox').stop();
	$('.contactBox').removeClass('visible');
	$('.rightHeader .contactInfo').removeClass('contactInfoActive');
	$('.contactBox').slideUp('normal', function() {});
}


/* About Box
------------------------------------*/
function aboutBox(){
	if($('.aboutBox').hasClass('visible'))
	{
		hideAboutBox();
	}
	else{
		showAboutBox();
	}
};

function showAboutBox(){
	//Scroll window
    $('html, body').animate({ scrollTop: '160' });

	$('.aboutBox').addClass('visible');
	$('.mainMenu .aboutInfoBox').addClass('aboutActive');
	$('.aboutBox').slideDown('slow', function() {});
}

function hideAboutBox(){
	$('.aboutBox').stop();
	$('.aboutBox').removeClass('visible');
	$('.mainMenu .aboutInfoBox').removeClass('aboutActive');
	$('.aboutBox').slideUp('normal', function() {});
}
