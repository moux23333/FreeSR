namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class JFLHHNAMPOB
	{
		[ProtoMember(13)] public int State;
		[ProtoMember(6)] public int ConfigId;
		[ProtoMember(9)] public int GroupId;
	}
	
}
