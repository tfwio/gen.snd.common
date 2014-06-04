﻿/*
 * Date: 11/12/2005
 * Time: 4:19 PM
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

using DspAudio.Midi.Common;
using DspAudio.Midi.Structures;
using CliEvent = System.EventArgs;
using CliHandler = System.EventHandler;

namespace DspAudio.Midi
{
	public class MidiKeySignature
	{
		public bool IsMajor;
		public KeySignatureType KeyType = KeySignatureType.C;
		
		public void SetSignature(KeySignatureType ksigtype, bool ismaj)
		{
			IsMajor = ismaj;
			KeyType = ksigtype;
		}
		public MidiKeySignature() : this(KeySignatureType.C,true)
		{
		}
		public MidiKeySignature(KeySignatureType ksigtype, bool ismaj)
		{
			SetSignature(ksigtype,ismaj);
		}
	}
}
