import os
import zipfile
import re

VERSION = "0.2.0"

def main():
    """Scratch Pad"""

    _regexUnderscoresAndMultipleDashes = r'[_-]{1,}'
    _regexTrimStartAndEnd = r'^[-]|[-]+$'

    filename = "--my__file--asd_another"
    print("--my__file--asd_another => " + re.sub(_regexUnderscoresAndMultipleDashes, "-", filename))

    #filename = "-start-and-end-"
    #print("-start-and-end- => " + re.sub(_regexTrimStartAndEnd, "", filename))


if __name__ == '__main__':
    main()