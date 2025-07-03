
document.addEventListener("DOMContentLoaded", function () {

    
    const cards = document.querySelectorAll('.card');

    
    cards.forEach((card, index) => {

        
        card.style.opacity = '0';

        
        card.style.transition = 'opacity 0.5s ease-in-out';

        setTimeout(() => {
            
            card.style.opacity = '1';
        }, 150 * index); 
    });
});