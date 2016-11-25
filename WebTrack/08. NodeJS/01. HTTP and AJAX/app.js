/* globals console require */
"use strict";

const listMoviesUrl = `http://www.imdb.com/search/title?genres=fantasy&title_tipe=feature&sort=moviemeter,asc&page=2&ref_=adv_nxt`;

const genres = ["fantasy", "horror", "comedy", "action", "sci-fi"];

const request = require("request");

request(listMoviesUrl, (err, res, body) => {
    console.log(body);
});