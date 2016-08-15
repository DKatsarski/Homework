function createCalendar(selector, events) {
    //selektirame elementa, za da moje da go prawim neshto
    var container = document.querySelector(selector);

    //trqbwa da generirame kalendara
    //moje da go naprawim ili s divcheta ili  s tablica 
    var dayBox = document.createElement('div');
    var dayBoxTitle = document.createElement('strong');
    var dayBoxContent = document.createElement('div');
    dayBoxContent.className = 'day-content';
    dayBoxTitle.className = 'day-title';

    dayBoxContent.innerHTML = '&nbsp'; // tuk slagame tekst, kojto zadyljitelno da go ima, za da ne se chipi talicata

    dayBox.appendChild(dayBoxTitle);
    dayBox.appendChild(dayBoxContent);
    

    var daysOfWeek = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];
    var selectedBox = null;

    //set styles 
    container.style.width = (120 * 7.5) + 'px'; // prawim gi da tochno sedem na red. 

    dayBox.style.margin = '0';
    dayBox.style.border = '1px solid black';
    dayBox.style.width = '120px';
    dayBox.style.height = '120px'; // do tuk naprawihme kutiika 
    //dayBox.style.float = 'left';  // po tozi nachin gi prawim taka, che da sa kato tablica 
    dayBox.style.display = 'inline-block';  // ako polzwame float, trqbwa da daem clear nqkyde

    dayBoxTitle.style.display = 'block'; // tuk zapylwame polencata na zaglawieto dokraj (bez towa ne stawa)
    dayBoxTitle.style.background = 'yellow';
    dayBoxTitle.style.textAlign = 'center';
    dayBoxTitle.style.color = 'green';
    dayBoxTitle.style.borderBottom = '1px solid black';
    
    

    function createMonthBoxes () {
        var dayBoxes = [];
        for(var i = 1; i <= 30; i += 1) {
            var dayOfWeek = daysOfWeek[(i-1) % daysOfWeek.length];
        dayBoxTitle.innerHTML = dayOfWeek + ' ' + (i) + ' Jun 2014';
        dayBoxes.push(dayBox.cloneNode(true));

        }



        return dayBoxes;
    }

    function addEvents(boxes, events) {
        for (var i = 0; i < events.length; i += 1) {
            var event = events[i];
            var content = boxes[event.date - 1].querySelector('.day-content'); // tuk i
            content.innerHTML = event.hour + ' ' + event.title;
        }
    }

    function resetBoxesStyles (boxes) {
        for (var i = 0; i < boxes.length; i += 1) {
            boxes[i].style.background = '';
        }
    }

    function onBoxMouseover (ev) {
        if (selectedBox !==  this) { // s toq if kazwame , da ne pipa, ako e pipnato. 
        this.style.background = 'gold';
            
        }
    }
      function onBoxMouseout (ev) {
         if (selectedBox !==  this) {
        this.style.background = '';
            
        }
        
    }
      function onBoxMouseClick (ev) {
          if (selectedBox) {
              selectedBox.style.background = '';
          }
          if (selectedBox === this) { // taq logika e, za da moje da se OTcweti obratno kato se klikne pak
              selectedBox = null;
          }
          else {
        this.style.background = 'yellowgreen'; // s tiq selectedBox prawim taka, che da ne ocwetqwame wsichko
        selectedBox = this;     
          }

    }// ako sme cyknali kutiikata, tq stqwa sinq, a na wsichki null im se maha sinioto 

    var boxes = createMonthBoxes();
    addEvents(boxes, events);

    var docFragment = document.createDocumentFragment();

    for(var i = 0; i < boxes.length; i += 1) {

        boxes[i].addEventListener('click', onBoxMouseClick);
        boxes[i].addEventListener('mouseover', onBoxMouseover);
        boxes[i].addEventListener('mouseout', onBoxMouseout);
        docFragment.appendChild(boxes[i]);
    }

    container.appendChild(docFragment);


};