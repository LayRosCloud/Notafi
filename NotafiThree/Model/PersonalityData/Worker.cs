using System.Data;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;


namespace NotafiThree.Model.PersonalityData
{
    public class Worker : DatabaseModel<Worker>
    {
        public Person Person{get; private set; }
        public Post Post{get; private set;}

        private readonly int _personId;
        private readonly int _postId;
        
        public Worker(int id, int person, int post) : this(id, null, null)
        {
            _personId = person;
            _postId = post;
        }

        public Worker(int id, Person person, Post post) : base(id)
        {
            Person = person;
            Post = post;

            _personId = person == null ? 0 : person.Id;
            _postId = post == null ? 0 : post.Id;
        }

        public void SetPersonOnId()
        {
            Person = (from x in NotafiThree.Model.DealData.DataSet.GetPersons() where x.Id == _personId select x).FirstOrDefault();
        }

        public void SetPostOnId(){
            Post post = new Post(0, "");
            Post = (from x in post.GetAllRows() where x.Id == _postId select x).FirstOrDefault();
        }

        public override void Insert()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@personId", Person.Id},
                {"@postId", Post.Id}
            };

            ExecuteQuery("INSERT INTO `Worker`(`PersonID`, `PostID`) VALUES (@personId,@postId)", dv);
        }

        public override void Update()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@personId", Person.Id},
                {"@postId", Post.Id},
                {"@id", Id}
            };

            ExecuteQuery("UPDATE `Worker` SET `PersonID`=@personId,`PostID`=@postId WHERE Id = @id", dv);
        }

        protected override Worker SelectCurrentObject(MySqlDataReader reader)
        {
            var id = reader.GetInt32(0);
            var personId = reader.GetInt32(1);
            var postId = reader.GetInt32(2);

            return new Worker(id, personId, postId);
        }
    }
}
