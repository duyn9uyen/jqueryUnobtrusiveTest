
jQuery.fn.shake = function(callback) {
    this.css({'position': 'relative'});
    return this.animate(
        {left: '-10px'}, 100
    ).animate(
        {left: '+10px'}, 100
    ).animate(
        {left: '-10px'}, 100
    ).animate(
        {left: '+10px'}, 100
    ).animate(
        {left: '0px'}, 100, callback);
};
    
