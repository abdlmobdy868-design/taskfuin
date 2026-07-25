
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>HTML Form Example</title>
    <style>
        * {
            box-sizing: border-box;
        }

        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            padding: 20px;
            margin: 0;
        }

        .container {
            max-width: 700px;
            margin: auto;
            background: white;
            padding: 30px;
            border-radius: 12px;
            box-shadow: 0 10px 30px rgba(0,0,0,0.2);
        }

        h2 {
            color: #333;
            text-align: center;
            margin-bottom: 10px;
        }

        p {
            text-align: center;
            color: #666;
            margin-bottom: 25px;
        }

        fieldset {
            border: 2px solid #667eea;
            border-radius: 8px;
            margin-bottom: 20px;
            padding: 15px 20px;
        }

        legend {
            font-weight: bold;
            color: #667eea;
            padding: 0 10px;
            font-size: 16px;
        }

        .form-group {
            margin-bottom: 15px;
            display: flex;
            flex-wrap: wrap;
            align-items: center;
        }

        label {
            width: 120px;
            font-weight: 600;
            color: #444;
            margin-bottom: 5px;
        }

        input[type="text"],
        input[type="email"],
        input[type="password"],
        select,
        textarea {
            flex: 1;
            min-width: 200px;
            padding: 10px 12px;
            border: 1px solid #ccc;
            border-radius: 6px;
            font-size: 14px;
            transition: 0.3s;
        }

            input:focus, select:focus, textarea:focus {
                border-color: #667eea;
                outline: none;
                box-shadow: 0 0 5px rgba(102, 126, 234, 0.5);
            }

        textarea {
            height: 80px;
            resize: vertical;
        }

        input[type="checkbox"] {
            margin-right: 8px;
            transform: scale(1.2);
        }

        input[type="range"] {
            flex: 1;
            min-width: 200px;
            accent-color: #667eea;
        }

        .buttons {
            text-align: center;
            margin-top: 20px;
            display: flex;
            gap: 10px;
            justify-content: center;
            flex-wrap: wrap;
        }

        input[type="submit"],
        input[type="reset"] {
            padding: 12px 30px;
            border: none;
            border-radius: 6px;
            font-size: 15px;
            font-weight: bold;
            cursor: pointer;
            transition: 0.3s;
            flex: 1;
            max-width: 200px;
        }

        input[type="submit"] {
            background: #667eea;
            color: white;
        }

            input[type="submit"]:hover {
                background: #5563d4;
            }

        input[type="reset"] {
            background: #999;
            color: white;
        }

            input[type="reset"]:hover {
                background: #777;
            }

        /* Responsive للموبايل */
        @media (max-width: 600px) {
            body {
                padding: 10px;
            }

            .container {
                padding: 20px;
            }

            .form-group {
                flex-direction: column;
                align-items: stretch;
            }

            label {
                width: 100%;
                margin-bottom: 8px;
            }

            input[type="text"],
            input[type="email"],
            input[type="password"],
            select,
            textarea,
            input[type="range"] {
                width: 100%;
                min-width: 100%;
            }

            .buttons {
                flex-direction: column;
            }

            input[type="submit"],
            input[type="reset"] {
                max-width: 100%;
                width: 100%;
            }
        }
    </style>
</head>
<body>

    <div class="container">
        <h2>HTML Form Example</h2>
        <p>This is an example of an HTML4-HTML5 form containing various input controls.</p>

        <form>
            <fieldset>
                <legend>User Information</legend>
                <div class="form-group">
                    <label>Username:</label>
                    <input type="text" name="username">
                </div>
                <div class="form-group">
                    <label>Email:</label>
                    <input type="email" name="email">
                </div>
                <div class="form-group">
                    <label>Password:</label>
                    <input type="password" name="password">
                </div>
            </fieldset>

            <fieldset>
                <legend>Contact Information</legend>
                <div class="form-group">
                    <label>Phone:</label>
                    <input type="text" name="phone">
                </div>
                <div class="form-group">
                    <label>Message:</label>
                    <textarea name="message"></textarea>
                </div>
            </fieldset>

            <fieldset>
                <legend>Subscription</legend>
                <input type="checkbox" name="sub1"> Subscribe to newsletter <br>
                <input type="checkbox" name="sub2"> Subscribe to newsletter
            </fieldset>

            <fieldset>
                <legend>Preferred Language</legend>
                <div class="form-group">
                    <label>Language:</label>
                    <select name="language">
                        <option>English</option>
                        <option>Arabic</option>
                        <option>Spanish</option>
                        <option>French</option>
                    </select>
                </div>
            </fieldset>

            <fieldset>
                <legend>Feedback</legend>
                <div class="form-group">
                    <label>Rate us:</label>
                    <input type="range" name="rating" min="0" max="10">
                </div>
            </fieldset>

            <div class="buttons">
                <input type="submit" value="Submit">
                <input type="reset" value="Reset">
            </div>
        </form>
    </div>

</body>
</html>
