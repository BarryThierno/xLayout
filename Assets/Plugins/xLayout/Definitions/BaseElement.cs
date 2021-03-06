using System.Collections.Generic;
using System.Xml.Serialization;

namespace xLayout.Definitions
{
    public class BaseElement
    {
        [XmlElement("GameObject", typeof(GameObjectElement))]
        [XmlElement("Prefab", typeof(PrefabElement))]
        [XmlElement("Button", typeof(ButtonElement))]
        [XmlElement("Label", typeof(LabelElement))]
        [XmlElement("Empty", typeof(EmptyElement))]
        [XmlElement("RawImage", typeof(RawImageElement))]
        [XmlElement("Image", typeof(ImageElement))]
        [XmlElement("VerticalLayout", typeof(VerticalLayoutElement))]
        [XmlElement("HorizontalLayout",typeof(HorizontalLayoutElement))]
        [XmlElement("GridLayout", typeof(GridLayoutElement))]
        [XmlElement("Scroll", typeof(ScrollElement))]
        [XmlElement("ListView", typeof(ListViewElement))]
        public List<BaseElement> Elements { get; set; }
    }
}