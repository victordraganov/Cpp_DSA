__author__ = 'Veke'


def extract_type(input, filter_type):
    filtered = ''
    for tup in input:
        if type(tup[0]) is filter_type:
            filtered += tup[0] * tup[1]
    return filtered


def reversed_dict(input):
    output = {}
    for key in input.keys():
        if not (key is output.values()):
            output[input[key]] = key
    return output


def flatten_dict(d):
    # If the value type is <class 'dict'> for every value
    # we add to  key '.' + value's key.
    def expand_sub_dict(key, value):
        print('1')
        if isinstance(value, dict):
            return [(key + '.' + k, v) for k, v in flatten_dict(value).items()]
        else:
            # Bottom of the recursion
            return [(key, value)]

    # We expand every item of the dictionary
    items = [i for k, v in d.items() for i in expand_sub_dict(k, v)]

    return dict(items)


def unflatten_dict(d):
    items = dict()
    for key, value in d.items():
        # We split the key to parts which are parted '.'
        parts = key.split('.')
        it = items
        for part in parts[:-1]:
            if part not in it:
                it[part] = dict()
            it = it[part]
        it[parts[-1]] = value
    return items


def reps(collection):
    output = [i for i in collection if collection.count(i) > 1]
    return output