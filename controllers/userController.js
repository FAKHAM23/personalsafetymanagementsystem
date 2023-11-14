const User =require('../models/user');
const jwt = require('jsonwebtoken'); 

async function createUser(req,res){
    try{
        const user = await User.create(req.body);
        res.status(201).json(user);
    }
    catch(err){
        res.status(500).json({error:err.message});
    }
}

async function updateUser(req,res){
    try{
        const { id }=req.params;
        const updateUser = await User.findByIdAndUpdate(id,req.body,{new:true});

        res.json(updateUser);
    }
    catch(err){
        res.status(500).json({  error:err.message});
    }
}

async function deleteUser(req,res){
    try{
        const { id }=req.params;
        const deleteUser = await User.findByIdAndRemove(id,req.body,{new:true});

        res.json(deleteUser);
    }
    catch(err){
        res.status(500).json({  error:err.message});
    }
}


async function getAllUser(req,res)
{
    try{
        const user = await User.find();
        res.json(user);
    }
    catch(err){
        res.status(500).json({error:err.message});
    }
}

// async function login(req, res) {
//     const { userName, password } = req.body;
  
//     try {
//       const user = await User.findOne({ userName, password });
  
//       if (!user) {
//         return res.status(401).json({ message: "Invalid username or password" });
//       }
  
//       res.status(200).json({ message: "Login successful", user });
//     } catch (error) {
//       console.error(error);
//       res.status(500).json({ message: "Server error" });
//     }
//   }

async function admindasboard(req, res){
    res.send('Welcome To Admin Dashboard');
}

function GenerateToken(user){
    const payload = {
    role: user.role,
    id: user._id,
     };
    const token = jwt.sign(payload, 'wdadadadad');
    return token;
    };
  async function login (req, res, next) {
    const { userName, password } = req.body;
    try {
      const user = await User.findOne({ userName });
      if (!user) return res.status(404).json({ error: 'User not found' });
      if (user.password!=password) return res.status(401).json({ error: 'Invalid credentials' });
      var token = GenerateToken(user);
      return res.status(200).json({
        message: 'Logged in successfully',
        email: userName,
        fullname: user.firstName,
        userid: user.id,
        token: token,
      });
    } catch (err) {
        return res.status(500).json({ message: err });
    }
   };

  

module.exports={
    createUser,
    updateUser,
    deleteUser,
    getAllUser,
    login,
    admindasboard
}


//helpful functions




