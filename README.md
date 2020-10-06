# CMDb API

Detta API hämtar och lagrar omröstningar i Communityn CMDb.

## Endpoints
Följande endpoints finns att tillgå

```html
'GET' api/movie
```
>Denna endpoint listar alla filmer i databasen
```json
[
    {
        "imdbID": "tt0111161",
        "numberOfLikes": 3,
        "numberOfDislikes": 3
    },
    {
        "imdbID": "tt9860728",
        "numberOfLikes": 6,
        "numberOfDislikes": 9
    },
    {
        "imdbID": "tt0258914",
        "numberOfLikes": 3,
        "numberOfDislikes": 1
    },
    {
        "imdbID": "tt0114369",
        "numberOfLikes": 5,
        "numberOfDislikes": 1
    }
]
```
```html
api/movie/imdbid
```
>Listar ratings för en film utifrån IMDB movie id
```json
{
    "imdbID": "tt0111161",
    "numberOfLikes": 3,
    "numberOfDislikes": 3
}
```

```html
api/movie/imdbid/like
api/movie/imdbid/dislike
```
>Ger antingen en röst på gilla eller ogilla på en specifik film
Returnerar: 
```json
{
    "imdbID": "tt0111161",
    "numberOfLikes": 3,
    "numberOfDislikes": 3
}
```




### Topplistan
```html
api/toplist
```
>Listar ratings som en topplilsta. Observer att länken inte bygger på Movie.
>Topplistan kan sorteras utifrån följande växlar:

Växel | Värde
------|------
sort | Asc eller desc
type | Rating eller popularity
count | heltal (antal filmer som visas)

