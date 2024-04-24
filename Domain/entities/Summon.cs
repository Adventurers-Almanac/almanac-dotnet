namespace AdventurersAlmanac.Domain.Entities
{

    public class Summon : Entity
    {
        public required SummonType SummonType { get; set; }

        public required string Title { get; set; }

        public required string Value { get; set; }

        public bool IsPrimary { get; set; }
        public short PriorityOrder { get; set; }
        public bool IsEnabled { get; set; }


        public Summon(SummonType type, string title, string value): base()
        {
            SummonType = type;
            Title = title;
            Value = value;

            IsEnabled = true;
        }

        public void SetAsPrimary()
        {
            IsPrimary = true;
        }


    }


    public enum SummonType
    {
        Unknown,
        Email,
        PhoneNumber,
        WebResource,
        Spell
    }


    /*

    "contactInfo": {
            "emails": [
                {
                    "type": "string",
                    "value": "string",
                    "isPrimary": "bool",
                    "isEnabled": "bool",
                    "priorityOrder": "number"
                }
            ],
            "phoneNumbers": [
                {
                    "type": "string",
                    "value": "string",
                    "isPrimary": "bool",
                    "isEnabled": "bool",
                    "priorityOrder": "number"
                }
            ],
            "webResources": [
                {
                    "type": "string",
                    "value": "string",
                    "isPrimary": "bool",
                    "isEnabled": "bool",
                    "priorityOrder": "number"
                }
            ]
        },

    */

}