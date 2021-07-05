# -*- coding: utf-8 -*-
import urllib2
import bs4
import sys
import re
url = "https://weather.naver.com/today/"
request = urllib2.Request(url)
# request = request.content.decode('utf-8', 'replace')
data = urllib2.urlopen(request).read()

parse = bs4.BeautifulSoup(data, 'html.parser')

temp = parse.find_all("strong",{"class": "current"})[0]
cur_temp = re.findall("\d+", str(temp))[0]

# dust = parse.find_all("em",{"class": "level_text"})
dust = parse.find_all("em",{"class": "level_text"})
dust = str(dust).split('>')[1].split('<')[0]

dust = parse.find_all("em",{"class": "level_text"})
dust = str(dust).split('>')[1].split('<')[0]

state = parse.find_all("span",{"class": "weather before_slash"})
state = str(state).split('>')[1].split('<')[0]

test = parse.find_all("span",{"class": "blind"})
test = str(test).split('>')[153].split('<')[0]
# if dust == "\xeb\xb3\xb4\xed\x86\xb5": dust = "soso"
# dust = str(dust).split('>')[1].split('<')[0]
# dust = str(dust)
# if dust == "보통": 
#     dust = "soso"
