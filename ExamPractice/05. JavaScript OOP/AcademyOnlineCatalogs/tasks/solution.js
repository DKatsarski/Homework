function solve() {
	const getId = (function () {
		let id = 0;

		return function () {
			id += 1;
			return id;
		};
	} ());

	class Item {
		constructor(description, name) {
			this.id = getId();
			this.description = description;
			this.name = name;
		}

		get description() {
			return this._description;
		}
		set description(description) {
			if (description === '') {
				throw 'There should be string';
			}
			if (typeof description !== 'string') {
				throw 'tha parameter should be string';
			}
			this._description = description;
		}

		get name() {
			return this._name;
		}
		set name(name) {
			if (name.length < 2 || name.length > 40) {
				throw 'the string should be more ...';
			}
			if (typeof name !== 'string') {
				throw 'the parameter should be string';
			}
			this._name = name;
		}
	}

	class Book extends Item {
		constructor(description, name, isbn, genre) {
			super(description, name);
			this.isbn = isbn;
			this.genre = genre;
		}

		get isbn() {
			return this._isbn;
		}

		set isbn(isbn) {
			if (typeof isbn !== 'string') {
				throw 'Isbn should be a string';
			}
			console.log(isbn.length);
			if (isbn.length !== 10 && isbn.length !== 13) {
				throw 'Isbn length should be either 10 or 13';
			}
			if (!isbn.match(/^[0-9]*$/)) {
				throw 'Isbn should be only digits';
			}

			this._isbn = isbn;
		}

		get genre() {
			return this._genre;
		}

		set genre(genre) {
			if (typeof genre !== 'string') {
				throw 'Genre should be a string';
			}
			if (genre.length < 2 || genre.length > 20) {
				throw 'the sting hsould be between 2 and 20';
			}

			this._genre = genre;
		}
	}

	class Media extends Item {
		constructor(description, name, duration, rating) {
			super(description, name);
			this.duration = duration;
			this.rating = rating;
		}

		get duration() {
			return this._duration;
		}

		set duration(duration) {
			if (typeof duration !== 'number') {
				throw 'duration should be a number';
			}
			if (duration <= 0) {
				throw 'the number should be graeted than 0';
			}
			this._duration = duration;
		}

		get rating() {
			return this._duration;
		}

		set rating(rating) {
			if (typeof rating !== 'number') {
				throw 'duration should be a number';
			}
			if (rating < 1 || rating > 5) {
				throw 'the number should be graeted than 0';
			}
			this._rating = rating;
		}
	}

	class Catalog {
		constructor(name) {
			this.name = name;
			this.items = [];
			this.id = getId();
		}

		get name() {
			return this._name;
		}
		set name(name) {
			if (typeof name !== 'string') {
				throw 'Name should be a string';
			}

			if (name.length < 2 || name.length > 40) {
				throw '';
			}
			this._name = name;
		}



		add(...items) {
			if (Array.isArray(items[0])) {
				items = items[0];
			}

			if (items.length === 0) {
				throw 'no items are added';
			}

			this.items.push(...items);
			return this;
		}

		find(x) {
			if (typeof x === 'number') {
				for (let item of this.items) {

					if (item.id === x) {
						return item;
					}
					return null;

				}
				if (x !== null && typeof x === 'object') {
					return this.items.filter(function (item) {
						return Object.keys(x).every(function (prop) {
							return x[prop] === item[prop];
						});
					});
				}
			}
		}

		search(pattern) {
			if (typeof pattern !== 'string' || pattern === '') {
				throw 'Search asd;flkj';
			}
			return this.items.filter(function (item) {
				return item.name.indexOf(pattern) >= 0 ||
					item.description.indexOf(pattern) >= 0;
			});
		}


	}

	class BookCatalog extends Catalog {
		constructor(name) {
			super(name);
		}

		add(...books) {
			if (Array.isArray(books[0])) {
				books = books[0];
			}

			books.forEach(function (x) {
				if (!x instanceof Book) {
					throw 'Must add only books';
				}
			});

			return super.add(...books);
		}

		getGenres() {
			let uniq = {};
			this.items.forEach(x => uniqp[x.genre] = true)

			return Object.keys(uniq);
		}

		find(x) {
			return super.find(x);
		}
	}

	class MediaCatalog extends Catalog {
		constructor(name) {
			super(name);
		}

		add(...medias) {
			if (Array.isArray(medias[0])) {
				medias = medias[0];
			}

			medias.forEach(function (x) {
				if (!(x instanceof Media)) {
					throw 'muse add only medias';
				}
			});
			return super.add(...medias);
		}

		getTop(count) {
			if (typeof count !== 'number') {
				throw 'Count should be a number';
			}
			if (count < 1) {
				throw 'Count must be more than 1';
			}

			return this.items
				.sort((a, b) => a.rating < b.rating)
				.filter((_, ind) => ind < count)
				.map(x => ({ id: x.id, name: x.name }));
		}

		getSortedByDuration() {
			return this.items
				.sort((a, b) => {
					if (a.duration === b.duration) {
						return a.id < b.id;
					}

					return a.duration > b.duration;
				});
		}

	}

	return {
		getBook: function (name, isbn, genre, description) {

			return new Book(description, name, isbn, genre);
		},
		getMedia: function (name, rating, duration, description) {
			return new Media(description, name, duration, rating);

		},
		getBookCatalog: function (name) {
			return new BookCatalog(name);

		},
		getMediaCatalog: function (name) {
			return new MediaCatalog(name);

		}
	};
}

module.exports = solve;
// var a = solve().getBook('asdf', '0123456789', 'aaaaaaaaaa', '34');
// console.log(a._description);

var numbers = ['Gosho', 'tosho', 'andriu'];
numbers.sort((a, b) => a > b);
console.log(numbers);

