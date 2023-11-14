const express = require('express');
const router = express.Router();
const userController = require('../controllers/userController');
const authorization = require('../utils/authorization_middleware');

router.post('/users', userController.createUser);
router.get('/users', userController.getAllUser);
router.put('/users/:id', userController.updateUser);
router.delete('/users/:id', userController.deleteUser);
router.post('/users/login', userController.login);
router.post('/admin', authorization.validateToken, userController.admindasboard);

// router.get('/api/endpoint', middleware1, middleware2, (req, res) => {
//     console.log('API endpoint handler');
//     res.send('API response');
//      });

router.get('/shared',authorization.validateToken,authorization.requireRoles(['Admin', 'Super User']), (req, res) => {
    res.json({ message: 'Shared endpoint' });
    });

module.exports = router;
