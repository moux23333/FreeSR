namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RogueDialogueEventParam
	{
		[ProtoMember(3)] public int DialogueEventId;
		[ProtoMember(4)] public int ArgId;
		[ProtoMember(9)] public float Ratio;
		[ProtoMember(1)] public bool IsValid;
	}

}
