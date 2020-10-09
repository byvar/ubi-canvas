using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class FontTemplate : TemplateObj {
		public FontTemplate.Info info;
		public FontTemplate.Common common;
		public CListO<FontTemplate.Page> pages;
		public CListO<FontTemplate.Char> chars;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				info = s.SerializeObject<FontTemplate.Info>(info, name: "info");
				common = s.SerializeObject<FontTemplate.Common>(common, name: "common");
				pages = s.SerializeObject<CListO<FontTemplate.Page>>(pages, name: "pages");
				chars = s.SerializeObject<CListO<FontTemplate.Char>>(chars, name: "chars");
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class Info : CSerializable {
			public string face;
			public int size;
			public bool bold;
			public bool italic;
			public string charset;
			public bool unicode;
			public int stretchH;
			public bool smooth;
			public bool aa;
			public uint paddingLeft;
			public uint paddingRight;
			public uint paddingTop;
			public uint paddingBottom;
			public uint spacingLeft;
			public uint spacingTop;
			public uint outline;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				face = s.Serialize<string>(face, name: "face");
				size = s.Serialize<int>(size, name: "size");
				bold = s.Serialize<bool>(bold, name: "bold");
				italic = s.Serialize<bool>(italic, name: "italic");
				charset = s.Serialize<string>(charset, name: "charset");
				unicode = s.Serialize<bool>(unicode, name: "unicode");
				stretchH = s.Serialize<int>(stretchH, name: "stretchH");
				smooth = s.Serialize<bool>(smooth, name: "smooth");
				aa = s.Serialize<bool>(aa, name: "aa");
				paddingLeft = s.Serialize<uint>(paddingLeft, name: "paddingLeft");
				paddingRight = s.Serialize<uint>(paddingRight, name: "paddingRight");
				paddingTop = s.Serialize<uint>(paddingTop, name: "paddingTop");
				paddingBottom = s.Serialize<uint>(paddingBottom, name: "paddingBottom");
				spacingLeft = s.Serialize<uint>(spacingLeft, name: "spacingLeft");
				spacingTop = s.Serialize<uint>(spacingTop, name: "spacingTop");
				outline = s.Serialize<uint>(outline, name: "outline");
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class Common : CSerializable {
			public int lineHeight;
			public int _base;
			public int scaleW;
			public int scaleH;
			public int pages;
			public bool packed;
			public int alphaChnl;
			public int redChnl;
			public int greenChnl;
			public int blueChnl;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				lineHeight = s.Serialize<int>(lineHeight, name: "lineHeight");
				_base = s.Serialize<int>(_base, name: "base");
				scaleW = s.Serialize<int>(scaleW, name: "scaleW");
				scaleH = s.Serialize<int>(scaleH, name: "scaleH");
				pages = s.Serialize<int>(pages, name: "pages");
				packed = s.Serialize<bool>(packed, name: "packed");
				alphaChnl = s.Serialize<int>(alphaChnl, name: "alphaChnl");
				redChnl = s.Serialize<int>(redChnl, name: "redChnl");
				greenChnl = s.Serialize<int>(greenChnl, name: "greenChnl");
				blueChnl = s.Serialize<int>(blueChnl, name: "blueChnl");
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class Char : CSerializable {
			public int id;
			public int x;
			public int y;
			public int width;
			public int height;
			public int xoffset;
			public int yoffset;
			public int xadvance;
			public int page;
			public int chnl;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				id = s.Serialize<int>(id, name: "id");
				x = s.Serialize<int>(x, name: "x");
				y = s.Serialize<int>(y, name: "y");
				width = s.Serialize<int>(width, name: "width");
				height = s.Serialize<int>(height, name: "height");
				xoffset = s.Serialize<int>(xoffset, name: "xoffset");
				yoffset = s.Serialize<int>(yoffset, name: "yoffset");
				xadvance = s.Serialize<int>(xadvance, name: "xadvance");
				page = s.Serialize<int>(page, name: "page");
				chnl = s.Serialize<int>(chnl, name: "chnl");
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class Page : CSerializable {
			public int id;
			public Path file;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				id = s.Serialize<int>(id, name: "id");
				file = s.SerializeObject<Path>(file, name: "file");
			}
		}
		public override uint? ClassCRC => 0x433A0C96;
	}
}

