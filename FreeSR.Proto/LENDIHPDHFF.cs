namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LENDIHPDHFF
	{
		[ProtoMember(1)] public int StageId;
		[ProtoMember(14)] public int Retcode;
	}

}
