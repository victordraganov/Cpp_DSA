__author__ = 'Veke'


def interpret_chinese_sign(year):
    chinese_signs = ["monkey", "rooster", "dog", "pig", "rat", "ox",
                     "tiger", "rabbit", "dragon", "snake", "horse", "sheep"]
    return chinese_signs[year % 12]


def interpret_western_sign(day, month):
    western_signs = [(3, 21, 4, 20, "aries"), (4, 21, 5, 20, "taurus"),
                     (5, 21, 6, 20, "gemini"), (6, 21, 7, 22, "cancer"),
                     (7, 23, 8, 22, "leo"), (8, 23, 9, 22, "virgo"),
                     (9, 23, 10, 22, "libra"), (10, 23, 11, 21, "scorpio"),
                     (11, 22, 12, 21, "sagittarius"),
                     (12, 22, 1, 20, "capricorn"),
                     (1, 21, 2, 18, "aquarius"), (2, 19, 3, 20, "pisces")]
    for sign in western_signs:
        if ((month == sign[0] and day >= sign[1])
                or (month == sign[2] and day <= sign[3])):
            return sign[4]


def interpret_both_signs(day, month, year):
    return interpret_western_sign(day, month), interpret_chinese_sign(year)