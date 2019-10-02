import logging

import azure.functions as func


def main(req: func.HttpRequest) -> func.HttpResponse:
    logging.info('Python HTTP trigger function processed a request. It returns an avenger')

    superheroes = { 
        'esteban': 'La massa Esteban', 
        'ruben': 'Capitan Arrebola', 
        'javi': 'Iron Javi',
        'simo': 'Sinior de la guerra',
        'virginia': 'Capitana Mejías',
        'alfons': 'Alfooooooonsssh Thunder'
    }

    name = req.params.get('name')
    if not name:
        try:
            req_body = req.get_json()
        except ValueError:
            pass
        else:
            name = eq_body.get('name')

    if name:
        name = name.lower()
        if name in superheroes:
            heroname = superheroes[name]
            return func.HttpResponse(f"The superhero with name {name} is {heroname}!")
        else:
            return func.HttpResponse(f"The superhero with name {name} does not exists")
    else:
        return func.HttpResponse(
             "Please pass a name on the query string or in the request body",
             status_code=400
        )
