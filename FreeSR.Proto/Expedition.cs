namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Expedition
	{
		[ProtoMember(11)] public List<int> AvatarIdList;
		[ProtoMember(15)] public int Id;
		[ProtoMember(12)] public int Duration;
		[ProtoMember(2)] public long AcceptTime;
	}
	
}
