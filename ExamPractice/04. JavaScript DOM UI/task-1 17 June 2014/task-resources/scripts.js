function createImagesPreviewer(selector, items) {
 // TODO: Check selector, check items, check items length
  // tuk prawim selector
  var root = document.querySelector(selector);

  var fragment = document.createDocumentFragment();

  //tuk e razpredelenioeto ot lqwo i ot dqsno.
  var imagePreviewer = document.createElement('div');// za da elementite na mqstoto si se prawqt ezi diwowe
  imagePreviewer.style.display = 'inline-block'; //stilizirame gi
  imagePreviewer.style.width = '75%';
  imagePreviewer.style.float = 'left';
  imagePreviewer.style.textAlign = 'center';

  var aside = document.createElement('div');
  aside.style.display = 'inline-block';
  aside.style.width = '25%';
  aside.style.textAlign = 'center';

  var selectedParent = document.createElement('div');//prawmi paretn nz oshte zashto/ maj zashtoto trqbwa da dobawim klas
  selectedParent.classList.add('image-preview');
  var selectedImageHeader = document.createElement('h3'); // tuk prawim zalgaweito an drugata golqma kartinkata
  selectedImageHeader.innerText = items[0].title;
  var selectedImage = document.createElement('img'); //prawim snimkata
  selectedImage.src = items[0].url;
  selectedImage.style.width = '80%';

  selectedParent.appendChild(selectedImageHeader);
  selectedParent.appendChild(selectedImage);// dobawqme elementite w tozi element i po dolu dobawqme elementa kym drugiq
  imagePreviewer.appendChild(selectedParent);


  //syzdawame input
  var input = document.createElement('input');
  var inputHeader = document.createElement('h3'); // tuk syzdawame headyer 
  inputHeader.innerText = 'Filter'; // tuk postawqme bulwite nad input-a
  input.addEventListener('keyup', function (ev) {
    var text = ev.target.value;

    var liChildern = listOfItems.getElementsByTagName('li');
    for (var i = 0, len = liChildern.length; i < len; i++) {
      var currentLi = liChildern[i];
      var header = currentLi.firstElementChild.innerText;
      if (header.toLowerCase().indexOf(text.toLowerCase()) >= 0) { // TUK PRAWI REALNO TYRSACHKATA 
        currentLi.style.display = 'block';
      }
      else {
          currentLi.style.display = 'none';
      }
    }

  }, false)

  var listOfItems = document.createElement('ul'); // tuk zapochwame logikata, za da dobawim elementite
  listOfItems.style.listStyleType = 'none'; // da nqmat tochki pred elementite ot lista 
  listOfItems.style.height = '500px';
  listOfItems.style.overflowY = 'scroll';// tuk slagame srolera po y koordinata
  listOfItems.addEventListener('click', function (ev) {
      var target = ev.target;
      if (target.tagName === 'IMG') {
        var header = target.previousElementSibling.innerText; // tuk namirame zaglawieto i kartinakta, za da q ugolemim
                                                                // ot lqvo
        var src = target.src;
        selectedImageHeader.innerText = header;
        selectedImage.src = src;
      };
  }, false);

  listOfItems.addEventListener('mouseover', function (ev){
      var target = ev.target;
      if (target.tagName === 'IMG') {
        target.parentElement.style.backgroundColor = 'gray';
        target.parentElement.style.cursor = 'pointer';
      }

  }, false);

  listOfItems.addEventListener('mouseout', function (ev) {
    var target = ev.target;
    if (target.tagName === 'IMG') {
      target.parentElement.style.backgroundColor = 'initial';
    }
  }, false)

  var li = document.createElement('li'); // dyzdawame li
  li.classList.add('image-container');
  var imageHeader = document.createElement('h3');
  var image = document.createElement('img');
  image.style.width = '90%';
  for (var i = 0, len = items.length; i < len; i += 1) // tuk trqbwa da klonirame headyer, kartinkata i da im setnem neshtata
  {
    var currentItem = items[i];
    var currentLi = li.cloneNode(true);
    var currentImageHeader = imageHeader.cloneNode(true);
    currentImageHeader.innerText = currentItem.title; // tuk popylawame teksta w Header-a 
    var currentImage = image.cloneNode(true);
    currentImage.src = currentItem.url; // tuk dobawqme socrsa na snimkata ot obekta w HTML-a

    currentLi.appendChild(currentImageHeader);
    currentLi.appendChild(currentImage);
    

    listOfItems.appendChild(currentLi);
  }


  aside.appendChild(inputHeader); // pirkachwame filtyra

  aside.appendChild(input); // tuk prikachwame input (tam kydeto pishem tekst) kym dqsnata strana. 
  aside.appendChild(listOfItems);


  fragment.appendChild(imagePreviewer);
  fragment.appendChild(aside);

  root.appendChild(fragment);

}