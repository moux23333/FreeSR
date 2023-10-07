namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FHCDGLKMMBG
	{
		[ProtoMember(9)] public int GroupId;
		[ProtoMember(6)] public int Retcode;
		[ProtoMember(10)] public int EntryId;
	}

}
