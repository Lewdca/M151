import mysql from "mysql2/promise";

const connection = await mysql.createConnection({
    host: "127.0.0.1",
    user: "root",
    password: "sml12345",
    database: "movie-db",
});

await connection.connect();

export async function getAll() {
    const query = 'SELECT * FROM Movies';
    const [data] = await connection.query(query);
    return data;
}

async function insert() { TODO }
async function update(movie) { TODO }
export async function get(id) { TODO }
export async function remove(id) {
    const query = 'DELETE FROM Movies WHERE id =' + id;
    const [data] = await connection.query(query);
    return data;
}
export function save(title, year) {
    const query = 'INSERT INTO Movies VALUES(' + title + ',' + year + ');'
    const [data] = connection.query(query);
    return data;
}