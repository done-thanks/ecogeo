// Find which language to display names in
var lang = $('.pageTitle')[0].getAttribute('data-lang');

var pageTitle = lang === 'English' ?
    'EcoAction Community Funding Program' :
    "Programme de financement communautaire ÉcoAction";
$('.pageTitle').append(pageTitle);

// Add desciptor text
var desciptorText = lang === 'English' ?
    "Protect, rehabilitate, enhance and sustain the natural environment, forms, guides, applicants and service standards." :
    "Protéger, rétablir, améliorer et conserver l’environnement naturel, formulaires, guides, demandeurs et normes de service.";
$('.pageDescription').append(desciptorText);
