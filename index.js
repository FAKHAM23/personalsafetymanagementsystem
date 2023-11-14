const express= require('express');
const path =require('path');
const userRoutes= require('./routes/userRoutes');
const bodyParser = require('body-parser');
require('./utils/db');
const app =express();
const port =3005;

// Middleware
app.use(bodyParser.json());
// APIsclss
app.use(express.static(path.join(__dirname,'static')))

app.use('/api',userRoutes);
app.get('/login',(req,res)=>{
    res.sendFile(__dirname + '/views/Login.html')
    // res.send('Welcome Fahad');
});

app.listen(port,()=>{
    console.log('Server is listening on port ${port}');
});

// app.get('/api/endpoint', middleware1, middleware2, (req, res) => {
//     console.log('API endpoint handler');
//     res.send('API response');
//      });

// app.get('/shared', requireRoles(['admin', 'Super User']), (req, res) => {
//     res.json({ message: 'Shared endpoint' });
//     });

