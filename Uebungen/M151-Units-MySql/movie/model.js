import mysql from 'mysql2/promise';

const connection = await mysql.createConnection({
    host: '127.0.0.1',
    //port: 3307,
    user: 'root',
    password: '',
    database: 'movie-db',
});

let i = 3
await connection.connect();
export async function getAll(userId) {
    const query = 'SELECT * FROM Movies WHERE public = 1 OR user = ?';
    const [data] = await connection.query(query, [userId]);
    return data;
}

export async function avarageRating(movieId) {
    const query = 'SELECT avg(rating) as rating FROM Rating WHERE fk_filmId = ?';
    const [data] = await connection.query(query, [movieId]);
    return data.pop();
}

export async function userRating(movieId, userId) {
    const query = 'SELECT * FROM Rating WHERE fk_filmId = ? AND fk_userId = ?';
    const [data] = await connection.query(query, [movieId, userId]);
    return data.pop();
}

export async function pushRating(rating) {
    const query = 'Insert Into Rating(id, rating, fk_filmId, fk_userId) VALUES (' + i + ' , ?, ?, ?)';
    const [result] = await connection.query(query, [rating.rating, rating.movieId, rating.userId])
    i++;
    return rating;
}

async function insert(movie) {
    const query = 'INSERT INTO Movies (title, year, user, public) VALUES (?, ?, ?, ?)';
    const [result] = await connection.query(query, [movie.title, movie.year, movie.user, movie.public]);
    return {...movie, id: result.insertId };
}

async function update(movie) {
    const query = 'UPDATE Movies SET title = ?, year = ?, public = ?, user = ? WHERE id = ?';
    await connection.query(query, [movie.title, movie.year, movie.public, movie.user, movie.id]);
    return movie;
}

export async function get(id) {
    const query = 'SELECT * FROM Movies WHERE id = ?';
    const [data] = await connection.query(query, [id]);
    return data.pop();
}

export async function remove(id) {
    const query = 'DELETE FROM Movies WHERE id = ?';
    await connection.query(query, [id]);
    return;
}

export function save(movie) {
    if (!movie.id) {
        return insert(movie);
    } else {
        return update(movie);
    }
}