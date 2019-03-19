using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class FontTemplate : TemplateObj {
		[Serialize("info"  )] public FontTemplate.Info info;
		[Serialize("common")] public FontTemplate.Common common;
		[Serialize("pages" )] public CList<FontTemplate.Page> pages;
		[Serialize("chars" )] public CList<FontTemplate.Char> chars;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(info));
				SerializeField(s, nameof(common));
				SerializeField(s, nameof(pages));
				SerializeField(s, nameof(chars));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class Info : CSerializable {
			[Serialize("face"         )] public string face;
			[Serialize("size"         )] public int size;
			[Serialize("bold"         )] public bool bold;
			[Serialize("italic"       )] public bool italic;
			[Serialize("charset"      )] public string charset;
			[Serialize("unicode"      )] public bool unicode;
			[Serialize("stretchH"     )] public int stretchH;
			[Serialize("smooth"       )] public bool smooth;
			[Serialize("aa"           )] public bool aa;
			[Serialize("paddingLeft"  )] public uint paddingLeft;
			[Serialize("paddingRight" )] public uint paddingRight;
			[Serialize("paddingTop"   )] public uint paddingTop;
			[Serialize("paddingBottom")] public uint paddingBottom;
			[Serialize("spacingLeft"  )] public uint spacingLeft;
			[Serialize("spacingTop"   )] public uint spacingTop;
			[Serialize("outline"      )] public uint outline;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(face));
				SerializeField(s, nameof(size));
				SerializeField(s, nameof(bold));
				SerializeField(s, nameof(italic));
				SerializeField(s, nameof(charset));
				SerializeField(s, nameof(unicode));
				SerializeField(s, nameof(stretchH));
				SerializeField(s, nameof(smooth));
				SerializeField(s, nameof(aa));
				SerializeField(s, nameof(paddingLeft));
				SerializeField(s, nameof(paddingRight));
				SerializeField(s, nameof(paddingTop));
				SerializeField(s, nameof(paddingBottom));
				SerializeField(s, nameof(spacingLeft));
				SerializeField(s, nameof(spacingTop));
				SerializeField(s, nameof(outline));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class Common : CSerializable {
			[Serialize("lineHeight")] public int lineHeight;
			[Serialize("base"      )] public int _base;
			[Serialize("scaleW"    )] public int scaleW;
			[Serialize("scaleH"    )] public int scaleH;
			[Serialize("pages"     )] public int pages;
			[Serialize("packed"    )] public bool packed;
			[Serialize("alphaChnl" )] public int alphaChnl;
			[Serialize("redChnl"   )] public int redChnl;
			[Serialize("greenChnl" )] public int greenChnl;
			[Serialize("blueChnl"  )] public int blueChnl;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(lineHeight));
				SerializeField(s, nameof(_base));
				SerializeField(s, nameof(scaleW));
				SerializeField(s, nameof(scaleH));
				SerializeField(s, nameof(pages));
				SerializeField(s, nameof(packed));
				SerializeField(s, nameof(alphaChnl));
				SerializeField(s, nameof(redChnl));
				SerializeField(s, nameof(greenChnl));
				SerializeField(s, nameof(blueChnl));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class Char : CSerializable {
			[Serialize("id"      )] public int id;
			[Serialize("x"       )] public int x;
			[Serialize("y"       )] public int y;
			[Serialize("width"   )] public int width;
			[Serialize("height"  )] public int height;
			[Serialize("xoffset" )] public int xoffset;
			[Serialize("yoffset" )] public int yoffset;
			[Serialize("xadvance")] public int xadvance;
			[Serialize("page"    )] public int page;
			[Serialize("chnl"    )] public int chnl;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(x));
				SerializeField(s, nameof(y));
				SerializeField(s, nameof(width));
				SerializeField(s, nameof(height));
				SerializeField(s, nameof(xoffset));
				SerializeField(s, nameof(yoffset));
				SerializeField(s, nameof(xadvance));
				SerializeField(s, nameof(page));
				SerializeField(s, nameof(chnl));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class Page : CSerializable {
			[Serialize("id"  )] public int id;
			[Serialize("file")] public Path file;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(file));
			}
		}
		public override uint? ClassCRC => 0x433A0C96;
	}
}

