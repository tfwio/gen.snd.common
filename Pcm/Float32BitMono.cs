﻿#region User/License
// oio * 7/19/2012 * 11:33 AM

// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.IO;

namespace DspAudio.Pcm
{
	public struct Float32BitMono
	{
		public int Sample;
	
		static public Float32BitMono[] Provide(Stream s, long offset, int count)
		{
			return IOHelper.ReadChunk<Float32BitMono>(offset,count,s);
		}
//		static public Float32BitMono[] Provide(ref byte[] data)
//		{
//			return IOHelper.ConvertBytes<Float32BitMono>(ref data);
//		}
		
		#region Op
		static public Float32BitMono operator +(Float32BitMono a, Float32BitMono b) { a.Sample += b.Sample; return a; }
		static public Float32BitMono operator -(Float32BitMono a, Float32BitMono b) { a.Sample -= b.Sample; return a; }
		static public Float32BitMono operator *(Float32BitMono a, Float32BitMono b) { a.Sample *= b.Sample; return a; }
		static public Float32BitMono operator /(Float32BitMono a, Float32BitMono b) { a.Sample /= b.Sample; return a; }
		static public Float32BitMono operator %(Float32BitMono a, Float32BitMono b) { a.Sample %= b.Sample; return a; }
		#endregion
	}
}
