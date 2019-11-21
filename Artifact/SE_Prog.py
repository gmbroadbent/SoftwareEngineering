# pip install <requirements path>

import credentials as c
import sys

import spotipy as sp    # pip install spotipy
import spotipy.util as util

#from spotify.auth.client import Client    # pip install spotify-api
from spotify import Client as Spotify

import spotify    # pip install -U spotify
import asyncio

from textblob import TextBlob as tb
import nltk


for arg in sys.argv:
    #print(arg)
    #print(arg[-4:])    ## See inf extention is '.txt' for headlines
    print()


global headlines
global usable_phrases

headlines = False
usable_phrases = False



def _readHeadlines():
    '''
        Fetches headlines retrieved by C# code
    '''
    print("_readHeadlines()")
    global headlines
    path = "headlines.txt"    ## todo: Ensure C# saves headlines where Python will loki
    file = open(path, 'r')
    headlines = file.readlines()
    
    for i in range(len(headlines)):
        headlines[i] = headlines[i][:-1]  ## Removes "\n" at end of line


def _removeSource():
    '''
        Removes " - <source>" from end of line
        Ensures no search for news orginisation
    '''
    print("_removeSource()")
    global headlines
    
    for i in range(len(headlines)):
        #print(headlines[i])
        for x in range(len(headlines[i])-1, 0-1, -1):
            if(headlines[i][x] == "-"):
                #print(headlines[i][:x-1])
                headlines[i] = headlines[i][:x-1]
                break
        #print()

def _fetchHeadlines():
    '''
        Simplifies
        Further code need only call this function, bot both others
    '''
    print("_fetchHeadlines()")
    _readHeadlines()
    #for line in headlines:
    #    print(line)

    #print()
    _removeSource()
    #for line in headlines:
    #    print(line)

    
    
    
    
    
    
    
def _spotipy():
    '''
        Attempting to use the 'Spotipy' API wrapper
    '''
    #spotify = sp.Spotify()
    #print(spotify)
    #results = spotify.search(q='artist: Stirling', type='artist')
    #print(len(results))

    token = util.prompt_for_user_token(c.sp_username, scope='playlist-modify-private', client_id=c.sp_client_id, client_secret=c.sp_client_secret, redirect_uri='http://localhost:8888/callback/')
    #print(token)

    
    
    


def spotify_api():
    '''
        Attempting to use the 'Spotify-api' API wrapper
    '''
    credentials = Client(c.sp_client_id, c.sp_client_secret)

    print(credentials)
    spfy = Spotify(credentials)
    print(spfy)

    search_result = spotify.search('shadows', ['track'])

    for trach in search_result:
        print(track.name)
        
        
        
        
        
        
        
#def _spotify():
#    '''
#        Attempting to use the 'Spotify' API wrapper
#    '''
#    client = spotify.Client(c.sp_client_id, c.sp_client_secret)
#
#    async def main():
#        #results = await client.search('avicci')
#        #for track in results.tracks:
#            #print(track)
#        #results = await client.search('avicci', types=['artist', 'track'])
#        #results = await client.search('avicci', limit=5, offset=20, market='GB')
#
#        user = await client.user_from_token(c.sp_username)
#
#        # create a spotify playlist
#        # and return a spotify.Playlist object
#        playlist = await user.create_playlist('playlist', description='songs')
#
#    #asyncio.get_event_loop().run_until_complete(main())
#    #main()
#
#    if __name__ == '__main__':
#        print("main")
#        #asyncio.get_event_loop().run_until_complete(main())
#        await main()

        
        
        
        
        
def _blobStuff():
    '''
        Refines headlines into searchable terms
    '''
    print("_blobStuff()")
    global headlines
    global usable_phrases
    
    if not headlines:
        _fetchHeadlines()

    nltk.download('punkt')
    nltk.download('averaged_perceptron_tagger')
    nltk.download('brown')
    nltk.download('wordnet')

    usable_phrases = []

    #for line in headlines:
        #print(line)
        #blob = tb(line)
        #print(blob.tags)
        #print(blob.noun_phrases)
        #print(blob.sentiment)
        #print()

    print()


    allHeadlines = ""
    for line in headlines:
        allHeadlines += (line + "\n")

    #print(allHeadlines)


    #blob = tb(open("headlines.txt", 'r').read())
    blob = tb(allHeadlines)


    #print(blob.noun_phrases)
    #for sentence in blob.sentences:
        #print(sentence.sentiment)

    print()

    for phrase in (blob.noun_phrases):
        usable = True
        for word in (tb(phrase).words):
            if word.define() == []:
                usable = False
                break
        if usable:
            usable_phrases.append(phrase)
        else:
            print(phrase)

    print()
    print()

    for phrase in usable_phrases:
        print(phrase)

        
        
print(headlines == False)
print(not headlines)
_fetchHeadlines()
print(headlines == False)
print(not headlines)


_blobStuff()