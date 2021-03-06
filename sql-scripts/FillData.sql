insert into PizzaComponent
(Name, Weight, Price, Category)
values
    ('Соус бургер', 60,  70, 0), ('Соус бургер', 80,  80, 0), ('Соус бургер', 100, 90, 0),
    ('Соус барбекю', 60,  55, 0), ('Соус барбекю', 80,  65, 0), ('Соус барбекю', 810, 75, 0),
    ('Томатный соус', 60,  40, 0), ('Томатный соус', 80,  50, 0), ('Томатный соус', 100, 60, 0),
    ('Соус Альфредо', 60,  60, 0), ('Соус Альфредо', 80,  70, 0), ('Соус Альфредо', 100, 80, 0),
    ('Соус Болоньезе', 60,  65, 0), ('Соус Болоньезе', 80,  75, 0), ('Соус Болоньезе', 100, 85, 0),
    ('Чеддер', 50, 75, 1), ('Чеддер', 60, 80, 1), ('Чеддер', 70, 85, 1),
    ('Брынза', 50, 50, 1), ('Брынза', 60, 60, 1), ('Брынза', 70, 70, 1),
    ('Пармезан', 50, 70, 1), ('Пармезан', 60, 80, 1), ('Пармезан', 70, 90, 1),
    ('Моцарелла', 50, 80,  1), ('Моцарелла', 60, 90, 1), ('Моцарелла', 70, 100, 1), ('Моцарелла', 80, 110, 1),
    ('Бекон', 60, 60, 2), ('Бекон', 70, 70, 2), ('Бекон', 80, 80, 2),
    ('Курица', 60, 50, 2), ('Курица', 70, 55, 2), ('Курица', 80, 60, 2),
    ('Ветчина', 60, 60, 2), ('Ветчина', 70, 70, 2), ('Ветчина', 80, 80, 2),
    ('Пепперони', 60, 50, 2), ('Пепперони', 70, 60, 2), ('Пепперони', 80, 70, 2),
    ('Томаты', 20, 15, 3), ('Томаты', 30, 20, 3), ('Томаты', 40, 25, 3),
    ('Маслины', 20, 35, 3), ('Маслины', 25, 40, 3), ('Маслины', 30, 45, 3),
    ('Шампиньоны', 40, 35, 3), ('Шампиньоны', 50, 45, 3), ('Шампиньоны', 60, 55, 3),
    ('Красный лук', 35, 15, 3), ('Красный лук', 40, 20, 3), ('Красный лук', 45, 25, 3),
    ('Сладкий перец', 30, 20, 3), ('Сладкий перец', 35, 30, 3), ('Сладкий перец', 40, 40, 3),
    ('Соленые огурцы', 30, 20, 3), ('Соленые огурцы', 40, 25, 3), ('Соленые огурцы', 50, 30, 3),
    ('Итальянские травы', 5, 10, 3), ('Итальянские травы', 10, 15, 3), ('Итальянские травы', 15, 20, 3),

    ('Чоризо', 30, 40, 2), ('Чоризо', 45, 60, 2), ('Чоризо', 60, 70, 2),
    ('Халапеньо', 15, 15, 3), ('Халапеньо', 20, 12, 3), ('Халапеньо', 25, 25, 3),
    ('Митболы', 30, 40, 2), ('Митболы', 45, 50, 2), ('Митболы', 60, 70, 2);

insert into Product
(Name, Description, ImageSrc, Category, Rating)
values
    ('Сырная', 'Моцарелла, сыры чеддер и пармезан, соус альфредо', 'Сырная.jpg', 0, 1),
    ('Пепперони', 'Пикантная пепперони, увеличенная порция моцареллы, томатный соус', 'Пепперони.jpg', 0, 12),
    ('Маргарита', 'Увеличенная порция моцареллы, томаты, итальянские травы, томатный соус', 'Маргарита.jpg', 0, 124),
    ('Цыпленок барбекю', 'Цыпленок, бекон, соус барбекю, красный лук, моцарелла, томатный соус', 'Цыпленок барбекю.jpg', 0, 65),
    ('Пепперони Фреш', 'Пикантная пепперони, увеличенная порция моцареллы, томаты, томатный соус', 'Пепперони Фреш.jpg', 0, 139),
    ('Чизбургер-пицца', 'Мясной соус болоньезе, соус бургер, соленые огурчики, томаты, красный лук, моцарелла', 'Чизбургер-пицца.jpg', 0, 18),
    ('Овощи и грибы', 'Шампиньоны, томаты, сладкий перец, красный лук, маслины, кубики брынзы, моцарелла, томатный соус, итальянские травы', 'Овощи и грибы.jpg', 0, 745),
    ('Четыре сезона', 'Увеличенная порция моцареллы, ветчина, пикантная пепперони, кубики брынзы, томаты, шампиньоны, итальянские травы, томатный соус', 'Четыре сезона.jpg', 0, 354),
    ('Диабло', 'Острая чоризо, острый перец халапеньо, соус барбекю, митболы, томаты, сладкий перец, красный лук, моцарелла, томатный соус', 'Диабло.jpg', 0, 19);

insert into PizzasCatalog
(PizzaId, Diameter, ThinDoughAvailable, Category)
values
    (1, 20, 0, 3), (1, 25, 0, 3), (1, 30, 0, 3),
    (2, 20, 1, 0), (2, 25, 1, 0), (2, 30, 1, 0),
    (3, 20, 1, 3), (3, 25, 1, 3), (3, 30, 0, 3),
    (4, 20, 1, 0), (4, 25, 1, 0), (4, 30, 0, 0),
    (5, 20, 0, 0), (5, 25, 1, 0), (5, 30, 1, 0),
    (6, 20, 1, 3), (6, 25, 0, 3), (6, 30, 1, 3),
    (7, 20, 1, 1), (7, 25, 0, 1), (7, 30, 1, 1),
    (8, 20, 0, 1), (8, 25, 1, 1), (8, 30, 1, 1),
    (9, 20, 1, 2), (9, 25, 1, 2), (9, 30, 1, 2);

insert into PizzaCatalogComponents
(CatalogId, ComponentId)
values
    (1, 25), (1, 16), (1, 22), (1, 10),
    (2, 26), (2, 17), (2, 23), (2, 11),
    (3, 27), (3, 18), (3, 24), (3, 12),

    (4, 38), (4, 26), (4, 7),
    (5, 39), (5, 27), (5, 8),
    (6, 40), (6, 28), (6, 9),

    (7, 26), (7, 41), (7, 59), (7, 7),
    (8, 27), (8, 42), (8, 60), (8, 8),
    (9, 28), (9, 43), (9, 61), (9, 9),

    (10, 32), (10, 29), (10, 4), (10, 50), (10, 25), (10, 7),
    (11, 33), (11, 30), (11, 5), (11, 51), (11, 26), (11, 8),
    (12, 34), (12, 31), (12, 6), (12, 52), (12, 27), (12, 9),

    (13, 38), (13, 26), (13, 41), (13, 7),
    (14, 39), (14, 27), (14, 42), (14, 8),
    (15, 40), (15, 28), (15, 43), (15, 9),

    (16, 13), (16, 1), (16, 56), (16, 41), (16, 50), (16, 25),
    (17, 14), (17, 2), (17, 57), (17, 42), (17, 51), (17, 26),
    (18, 15), (18, 3), (18, 58), (18, 43), (18, 52), (18, 27),

    (19, 47), (19, 41), (19, 53), (19, 50), (19, 44), (19, 19), (19, 25), (19, 7), (19, 59),
    (20, 48), (20, 42), (20, 54), (20, 51), (20, 45), (20, 20), (20, 26), (20, 8), (20, 60),
    (21, 49), (21, 43), (21, 55), (21, 52), (21, 46), (21, 21), (21, 27), (21, 9), (21, 61),

    (22, 26), (22, 35), (22, 38), (22, 19), (22, 41), (22, 47), (22, 59), (22, 7),
    (23, 27), (23, 36), (23, 39), (23, 20), (23, 42), (23, 48), (23, 60), (23, 8),
    (24, 28), (24, 37), (24, 40), (24, 21), (24, 43), (24, 49), (24, 61), (24, 9),

    (25, 62), (25, 65), (25, 4), (25, 68), (25, 41), (25, 53), (25, 50), (25, 25), (25, 7),
    (26, 63), (26, 66), (26, 5), (26, 69), (26, 42), (26, 54), (26, 51), (26, 26), (26, 8),
    (27, 64), (27, 67), (27, 6), (27, 70), (27, 43), (27, 55), (27, 52), (27, 27), (27, 9);
