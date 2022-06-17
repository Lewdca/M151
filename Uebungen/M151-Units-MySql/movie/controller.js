import { getAll, remove, get, save, avarageRating, userRating, pushRating } from './model.js';
import { render } from './view.js';
import { render as form } from './form.js';

export async function listAction(request, response) {
    let movies = await getAll(request.user.id);
    const data = [];
    for (let movie of movies) {
        const avgRating = (await avarageRating(movie.id)).rating;
        const personalRating = (await userRating(movie.id, request.user.id));
        data.push({
            ...movie,
            avgRating: avgRating,
            personalRating: personalRating
        });
    }
    const body = render(data);
    response.send(body);
}

export async function newRating(request, response) {
    let personalRating = await userRating(parseInt(request.params.id), request.user.id);
    let rating = {
        id: personalRating ? personalRating.id : null,
        userId: request.user.id,
        movieId: parseInt(request.params.id),
        rating: parseInt(request.params.rating)
    }
    pushRating(rating);
}


export async function removeAction(request, response) {
    const id = parseInt(request.params.id, 10);
    await remove(id);
    response.redirect(request.baseUrl);
}

export async function formAction(request, response) {
    let movie = { id: '', title: '', year: '', public: '' };

    if (request.params.id) {
        movie = await get(parseInt(request.params.id, 10));
    }

    console.log(movie);

    const body = form(movie);
    response.send(body);
}

export async function saveAction(request, response) {
    const movie = {
        id: request.body.id,
        title: request.body.title,
        year: request.body.year,
        user: request.user.id,
        public: request.body.public == "true" ? true : false
    };
    await save(movie);
    response.redirect(request.baseUrl);
}