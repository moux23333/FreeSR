namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetGenderCsReq
	{
		[ProtoMember(14)] public Gender Gender;
	}
	
}
