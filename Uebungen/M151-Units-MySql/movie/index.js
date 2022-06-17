import { Router } from 'express';
import {
    listAction,
    newRating,
    removeAction,
    formAction,
    saveAction,
} from './controller.js';
import { pushRating } from './model.js';

const router = Router();

router.get('/', listAction);
router.get('/:id/rate/:rating', newRating);
router.get('/delete/:id', removeAction);
router.get('/form/:id?', formAction);
router.post('/save', saveAction);

export { router };