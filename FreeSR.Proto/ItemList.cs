namespace FreeSR.Proto
{
	using ProtoBuf;

    [ProtoContract]
    public class ItemList
    {
        [ProtoMember(5)] public List<Item> List;
    }

}
