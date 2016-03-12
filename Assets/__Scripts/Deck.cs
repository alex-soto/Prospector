﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : MonoBehaviour {
	[Header("Variables")]
	public PT_XMLReader xmlr;

	// InitDeck is called by Prospector when it is ready
	public void InitDeck(string deckXMLtext){
		ReadDeck (deckXMLtext);
	}

	// ReadDeck parses the XML file passed to it into CardDefinitions
	public void ReadDeck(string deckXMLText){
		xmlr = new PT_XMLReader (); // Create a new PT_XMLReader
		xmlr.Parse (deckXMLText); // Use that PT_XMLReader to parse DeckXML

		// This prints a test line to show you how xmlr can be used.
		string s = "xml[0] decorator[0] ";
		s += "type=" + xmlr.xml ["xml"] [0] ["decorator"] [0].att ("type");
		s += " x="+xmlr.xml["xml"][0]["decorator"][0].att ("x");
		s += " y="+xmlr.xml["xml"][0]["decorator"][0].att ("y");
		s += " scale="+xmlr.xml["xml"][0]["decorator"][0].att ("scale");
		print (s);
	}
}
