from flask import Flask, request, jsonify
import json
import sqlite3

app = Flask(__name__)

@app.route('/')
def index():
    user_agent = request.headers.get('User-Agent')
    return user_agent

def db_connection():
    conn = None
    try:
        conn = sqlite3.connect('db.sqlite') 
        conn.execute("""CREATE TABLE IF NOT EXISTS db (id INTEGER PRIMARY KEY AUTOINCREMENT, podID TEXT, avaliability INTEGER)""") #Avaliability is a bool. 0-false, 1-true
    except sqlite3.error as e:
        print(e)
    return conn

@app.route('/data', methods=["GET","POST"])
def handle_Data():
    conn = db_connection()
    cursor = conn.cursor()

    if request.method == "GET":
        print("Getting data")

        cursor = conn.execute("SELECT * FROM db")
        data = [
            dict(id=row[0], podID = row[1], avaliability=row[2])
            for row in cursor.fetchall()
        ]

        if data is not None:
            return jsonify(data)

    if request.method == "POST":
        print("Posting data")

        new_podID = request.form["podID"]
        new_Avaliability = request.form["avaliability"]

        if( new_Avaliability == ""  or new_podID== ""):
            return "No data was passed into POST function"
        if(not json.loads(new_Avaliability.lower())):
            return "Invalid avaliability data type. Must be bool"

        sql  = """INSERT INTO db (podID, avaliability) 
                VALUES (?, ?)"""

        cursor = conn.execute(sql, (new_podID, new_Avaliability))
        conn.commit()
        return f"DB item created with ID: {cursor.lastrowid}",201

@app.route("/db/<int:id>")
def get_DBItem(id, METHODS=["GET","PUT","DELETE"]):
    conn = db_connection()
    cursor = conn.cursor()

    item = None

    if request.method=="GET":
        cursor.execute("SELECT * FROM db WHERE id=?", (id,))
        rows = cursor.fetchall()
        for r in rows:
            item = r;
        if item is not None:
            return jsonify(item),200
        else:
            return "Something went wrong",404

    if request.method == "PUT":
        sql = """UPDATE book
                SET podID = ?,
                SET avaliability = ?,
                WHERE id=? """

        avaliability = request.form["avaliability"]
        updated_item = {
            "id" : id,
            "podID" : podID,
            "avaliability" : avaliability
        }
        cursor = conn.execute(sql, (podID, avaliability,id))
        conn.commit()
        return jsonify(updated_item)

    if request.method == "DELETE":
        sql = """ DELETE FROM db WHERE id=? """
        conn.execute(sql, (id,))
        conn.commit()
        return "The item with id: {} has been deleted".format(id),200

@app.errorhandler(404)
def page_not_found(error):
    return 'This page does not exist', 404

@app.errorhandler(400)
def bad_request(error):
    return "Bad request syntax", 400

if __name__ == '__main__':
    app.run(debug=False)